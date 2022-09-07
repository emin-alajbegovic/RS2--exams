// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'emin.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Emin _$EminFromJson(Map<String, dynamic> json) => Emin()
  ..favoritiId = json['favoritiId'] as int?
  ..proizvodId = json['proizvodId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..username = json['username'] as String?
  ..email = json['email'] as String?
  ..firstName = json['firstName'] as String?
  ..lastName = json['lastName'] as String?;

Map<String, dynamic> _$EminToJson(Emin instance) => <String, dynamic>{
      'favoritiId': instance.favoritiId,
      'proizvodId': instance.proizvodId,
      'korisnikId': instance.korisnikId,
      'username': instance.username,
      'email': instance.email,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
    };
