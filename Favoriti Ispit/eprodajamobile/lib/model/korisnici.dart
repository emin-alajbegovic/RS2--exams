import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';

part 'korisnici.g.dart';

@JsonSerializable()
class Korisnici {
  int? korisnikId;
  String? ime;

  Korisnici() {}

  factory Korisnici.fromJson(Map<String, dynamic> json) =>
      _$KorisniciFromJson(json);

  /// Connect the generated [_$KorisniciToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KorisniciToJson(this);
}
