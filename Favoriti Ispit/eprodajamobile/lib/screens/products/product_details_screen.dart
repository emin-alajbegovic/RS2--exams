import 'package:eprodajamobile/model/favoriti.dart';
import 'package:eprodajamobile/model/product.dart';
import 'package:eprodajamobile/providers/favoriti_provider.dart';
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
  Product? product = null;
  List<Favoriti> favoriti = [];
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    _productProvider = context.read<ProductProvider>();
    _favoritiProvider = context.read<FavoritiProvider>();
    print("called initState");
    loadData();
  }

  Future loadData() async {
    var tmpData = await _productProvider?.getDetailsById(int.parse(widget.id));
    setState(() {
      product = tmpData!;
    });
    loadFavoritesByKorisnik();
  }

  Future loadFavoritesByKorisnik() async {
    var tmpFavorites = await _favoritiProvider?.get({"proizvodId": widget.id});
    print(tmpFavorites);
    setState(() {
      favoriti = tmpFavorites!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      child: Center(
        child: SingleChildScrollView(
          child: _buildProductCard(),
        ),
      ),
    );
  }

  Widget _buildProductCard() {
    if (product == null) {
      return Text("loading...");
    }

    Widget list = Container(
      child: Column(
        children: [
          Positioned(child: imageFromBase64String(product!.slika!)),
          Text(product!.naziv!),
          Text(product!.cijena!.toString()),
          TextButton(
              onPressed: () {
                var favorit = {
                  "proizvodId": product!.proizvodId!,
                  "korisnikId": 1
                };
                _favoritiProvider!.insert(favorit);
                loadData();
              },
              child: Text("Dodaj u favorite")),
          Text("Favoriti"),
          Center(
            child: Container(
              height: 200,
              child: ListView(
                shrinkWrap: true,
                children: _favoritiList(),
              ),
            ),
          ),
        ],
      ),
    );
    return list;
  }

  List<Widget> _favoritiList() {
    if (favoriti.length == null) {
      return [Text("Loading...")];
    }

    List<Widget> list = favoriti
        .map((x) => Container(
              child: Row(
                children: [
                  Text("Proizvod: " + x.proizvodId.toString()),
                  Text("  Korisnik: " + x.korisnikId.toString()),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();

    return list;
  }
}
