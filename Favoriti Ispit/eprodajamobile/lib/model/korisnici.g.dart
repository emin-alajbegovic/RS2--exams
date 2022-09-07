// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'korisnici.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Korisnici _$KorisniciFromJson(Map<String, dynamic> json) => Korisnici()
  ..korisnikId = json['korisnikId'] as int?
  ..ime = json['ime'] as String?
  ..prezime = json['prezime'] as String?
  ..email = json['email'] as String?
  ..korisnickoIme = json['korisnickoIme'] as String?;

Map<String, dynamic> _$KorisniciToJson(Korisnici instance) => <String, dynamic>{
      'korisnikId': instance.korisnikId,
      'ime': instance.ime,
      'prezime': instance.prezime,
      'email': instance.email,
      'korisnickoIme': instance.korisnickoIme,
    };
