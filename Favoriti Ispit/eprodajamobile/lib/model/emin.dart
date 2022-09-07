import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';

part 'emin.g.dart';

@JsonSerializable()
class Emin {
  int? favoritiId;
  int? proizvodId;
  int? korisnikId;
  String? username;
  String? email;
  String? firstName;
  String? lastName;

  Emin() {}

  factory Emin.fromJson(Map<String, dynamic> json) => _$EminFromJson(json);

  /// Connect the generated [_$EminToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$EminToJson(this);
}
