import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:eprodajamobile/model/korisnici.dart';
import 'package:eprodajamobile/model/product.dart';
import 'package:eprodajamobile/providers/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class KorisniciProvider extends BaseProvider<Korisnici> {
  KorisniciProvider() : super("Korisnici");

  @override
  Korisnici fromJson(data) {
    return Korisnici.fromJson(data);
  }
}
