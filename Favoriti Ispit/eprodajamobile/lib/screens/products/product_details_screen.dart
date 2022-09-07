import 'package:eprodajamobile/model/emin.dart';
import 'package:eprodajamobile/model/favoriti.dart';
import 'package:eprodajamobile/model/korisnici.dart';
import 'package:eprodajamobile/model/product.dart';
import 'package:eprodajamobile/providers/emin_provider.dart';
import 'package:eprodajamobile/providers/favoriti_provider.dart';
import 'package:eprodajamobile/providers/korisnici_provider.dart';
import 'package:eprodajamobile/providers/product_provider.dart';
import 'package:eprodajamobile/utils/util.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:provider/provider.dart';

import '../../widgets/master_screen.dart';

class ProductDetailsScreen extends StatefulWidget {
  static const String routeName = "/product_details";
  String id;
  ProductDetailsScreen(this.id, {Key? key}) : super(key: key);

  @override
  State<ProductDetailsScreen> createState() => _ProductDetailsScreenState();
}

class _ProductDetailsScreenState extends State<ProductDetailsScreen> {
  ProductProvider? _productProvider = null;
  FavoritiProvider? _favoritiProvider = null;
  EminProvider? _eminProvider = null;
  Product? product = null;
  KorisniciProvider? _korisniciProvider = null;
  TextEditingController _searchController = TextEditingController();
  Korisnici? korisnik = null;
  List<Emin> lists = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _productProvider = context.read<ProductProvider>();
    _favoritiProvider = context.read<FavoritiProvider>();
    _korisniciProvider = context.read<KorisniciProvider>();
    _eminProvider = context.read<EminProvider>();
    print("called initState");
    loadData();
    loadUserData();
  }

  Future loadData() async {
    var tmpData = await _productProvider?.getByDetailsId(int.parse(widget.id));
    setState(() {
      product = tmpData!;
    });
  }

  Future loadUserData() async {
    var tmpData = await _korisniciProvider
        ?.getUserByUsername(Authorization.username.toString());
    print(tmpData);
    setState(() {
      korisnik = tmpData!;
    });
    loadUserFavoritesData();
  }

  Future loadUserFavoritesData() async {
    var tmpData =
        await _eminProvider?.getByUserProizvodId(int.parse(widget.id));
    setState(() {
      lists = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(
        child: SingleChildScrollView(child: _buildProductList()),
      ),
    );
  }

  Widget _buildProductList() {
    if (product == null) {
      return Text("loading...");
    }

    Widget list = Container(
      child: Column(children: [
        Positioned(child: imageFromBase64String(product!.slika!)),
        Text(product!.naziv!),
        Text(product!.cijena.toString()),
        TextButton(
            onPressed: () {
              var object = {
                "korisnikId": korisnik?.korisnikId,
                "proizvodId": widget.id
              };

              _favoritiProvider?.insert(object);
              loadData();
            },
            child: Text("Dodaj u favorite")),
        Text("Favoriti"),
        Container(
          height: 200,
          child: ListView(shrinkWrap: true, children: _loadFavoritesList()),
        )
      ]),
    );
    return list;
  }

  List<Widget> _loadFavoritesList() {
    if (lists.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = lists
        .map((x) => Container(
              child: Column(
                children: [
                  Text(x.firstName.toString()),
                  Text(x.lastName.toString()),
                  Text(x.username.toString()),
                  Text(x.email.toString()),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
