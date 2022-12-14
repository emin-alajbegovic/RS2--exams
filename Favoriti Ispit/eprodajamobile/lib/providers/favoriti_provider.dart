import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:eprodajamobile/model/favoriti.dart';
import 'package:eprodajamobile/providers/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class FavoritiProvider extends BaseProvider<Favoriti> {
  FavoritiProvider() : super("Favoriti");

  @override
  Favoriti fromJson(data) {
    return Favoriti.fromJson(data);
  }
}
