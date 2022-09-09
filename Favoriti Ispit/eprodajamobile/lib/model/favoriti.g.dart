// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'favoriti.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Favoriti _$FavoritiFromJson(Map<String, dynamic> json) => Favoriti()
  ..favoritiId = json['favoritiId'] as int?
  ..proizvodId = json['proizvodId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..username = json['username'] as String?
  ..email = json['email'] as String?;

Map<String, dynamic> _$FavoritiToJson(Favoriti instance) => <String, dynamic>{
      'favoritiId': instance.favoritiId,
      'proizvodId': instance.proizvodId,
      'korisnikId': instance.korisnikId,
      'username': instance.username,
      'email': instance.email,
    };
