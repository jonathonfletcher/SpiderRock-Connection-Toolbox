# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SRMLinkAnalytics/LiveBasisCurve.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n%SRMLinkAnalytics/LiveBasisCurve.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x93\x04\n\x0eLiveBasisCurve\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x36\n\x04pkey\x18\x02 \x01(\x0b\x32(.spiderrock.protobuf.LiveBasisCurve.PKey\x12\r\n\x05min_x\x18\x64 \x01(\x01\x12\r\n\x05max_x\x18\x65 \x01(\x01\x12\x0e\n\x06left_a\x18\x66 \x01(\x01\x12\x0e\n\x06left_b\x18g \x01(\x01\x12\x0f\n\x07right_a\x18h \x01(\x01\x12\x0f\n\x07right_b\x18i \x01(\x01\x12\x12\n\nnum_points\x18m \x01(\x05\x12\x14\n\x0cnum_expiries\x18n \x01(\x05\x12\x0f\n\x07\x66it_mAE\x18o \x01(\x01\x12-\n\ttimestamp\x18p \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x38\n\x05point\x18j \x03(\x0b\x32).spiderrock.protobuf.LiveBasisCurve.Point\x1aq\n\x04PKey\x12,\n\x04\x65key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12;\n\x0csurface_type\x18\x0b \x01(\x0e\x32%.spiderrock.protobuf.SurfaceCurveType\x1a\x1d\n\x05Point\x12\t\n\x01x\x18k \x01(\x01\x12\t\n\x01y\x18l \x01(\x01\x62\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SRMLinkAnalytics.LiveBasisCurve_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_LIVEBASISCURVE']._serialized_start=121
  _globals['_LIVEBASISCURVE']._serialized_end=652
  _globals['_LIVEBASISCURVE_PKEY']._serialized_start=508
  _globals['_LIVEBASISCURVE_PKEY']._serialized_end=621
  _globals['_LIVEBASISCURVE_POINT']._serialized_start=623
  _globals['_LIVEBASISCURVE_POINT']._serialized_end=652
# @@protoc_insertion_point(module_scope)