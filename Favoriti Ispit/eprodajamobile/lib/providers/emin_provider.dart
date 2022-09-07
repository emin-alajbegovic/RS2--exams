import 'dart:convert';
import 'dart:io';
import 'dart:async';
import 'package:eprodajamobile/model/emin.dart';
import 'package:eprodajamobile/providers/base_provider.dart';
import 'package:http/http.dart';
import 'package:http/io_client.dart';
import 'package:flutter/foundation.dart';

class EminProvider extends BaseProvider<Emin> {
  EminProvider() : super("Favoriti");

  @override
  Emin fromJson(data) {
    return Emin.fromJson(data);
  }
}
