import 'package:eprodajamobile/model/favoriti.dart';
import 'package:eprodajamobile/model/korisnici.dart';
import 'package:eprodajamobile/model/product.dart';
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
  KorisniciProvider? _korisniciProvider = null;
  Product? product = null;
  Korisnici? korisnik = null;
  List<Favoriti> favoritis = [];

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _productProvider = context.read<ProductProvider>();
    _favoritiProvider = context.read<FavoritiProvider>();
    _korisniciProvider = context.read<KorisniciProvider>();
    print("called initState");
    loadData();
    loadUserData();
  }

  Future loadData() async {
    var tmpData = await _productProvider?.getDetailsById(int.parse(widget.id));
    setState(() {
      product = tmpData!;
    });
    loadFAvoritesUserData();
  }

  Future loadUserData() async {
    var tmpData = await _korisniciProvider
        ?.getByUsernameId(Authorization.username.toString());
    setState(() {
      korisnik = tmpData!;
    });
  }

  Future loadFAvoritesUserData() async {
    var tmpData = await _favoritiProvider?.get({"proizvodId": widget.id});
    setState(() {
      favoritis = tmpData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(
        child: SingleChildScrollView(
          child: _buildProductList(),
        ),
      ),
    );
  }

  Widget _buildProductList() {
    if (product == null) {
      return Text("Loading..");
    }

    Widget list = Container(
      child: Column(children: [
        Positioned(child: imageFromBase64String(product!.slika!)),
        Text(product!.naziv!),
        Text(product!.cijena.toString()),
        TextButton(
            onPressed: () {
              var obj = {
                "korisnikId": korisnik!.korisnikId,
                "proizvodId": widget.id
              };
              _favoritiProvider?.insert(obj);

              loadData();
            },
            child: Text("Dodaj u favorite")),
        Container(
          height: 200,
          child: ListView(
            shrinkWrap: true,
            children: _buildFavoritesList(),
          ),
        )
      ]),
    );

    return list;
  }

  List<Widget> _buildFavoritesList() {
    if (favoritis.length == 0) {
      return [Text("Loading...")];
    }

    List<Widget> list = favoritis
        .map((x) => Container(
              child: Column(
                children: [
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
