import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';

part 'favoriti.g.dart';

@JsonSerializable()
class Favoriti {
  int? favoritiId;
  int? proizvodId;
  int? korisnikId;

  Favoriti() {}

  factory Favoriti.fromJson(Map<String, dynamic> json) =>
      _$FavoritiFromJson(json);

  /// Connect the generated [_$FavoritiToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$FavoritiToJson(this);
}
