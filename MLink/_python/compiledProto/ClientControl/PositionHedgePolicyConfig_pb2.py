# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientControl/PositionHedgePolicyConfig.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import duration_pb2 as google_dot_protobuf_dot_duration__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n-ClientControl/PositionHedgePolicyConfig.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1egoogle/protobuf/duration.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xc3\x0c\n\x19PositionHedgePolicyConfig\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x41\n\x04pkey\x18\x02 \x01(\x0b\x32\x33.spiderrock.protobuf.PositionHedgePolicyConfig.PKey\x12+\n\x07\x65nabled\x18\x64 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12=\n\x10hedge_delta_rule\x18\x65 \x01(\x0e\x32#.spiderrock.protobuf.HedgeDeltaRule\x12\x13\n\x0b\x62inary_days\x18\x66 \x01(\x02\x12\x33\n\x0f\x62\x61lance_symbols\x18k \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x32\n\nhedge_algo\x18l \x01(\x0e\x32\x1e.spiderrock.protobuf.HedgeAlgo\x12\x16\n\x0e\x65xec_brkr_algo\x18m \x01(\t\x12\x16\n\x0e\x65xec_brkr_code\x18n \x01(\t\x12\x16\n\x0e\x65xec_bkkr_tags\x18o \x01(\t\x12:\n\x10\x65od_hedge_window\x18p \x01(\x0e\x32 .spiderrock.protobuf.HedgeWindow\x12\x1d\n\x15\x65od_sym_hedge_band_dD\x18q \x01(\x02\x12\x1d\n\x15\x65od_sym_hedge_band_gR\x18r \x01(\x02\x12\x37\n\x13\x65od_balance_symbols\x18s \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x36\n\x0e\x65od_hedge_algo\x18t \x01(\x0e\x32\x1e.spiderrock.protobuf.HedgeAlgo\x12\x1a\n\x12\x65od_exec_brkr_algo\x18u \x01(\t\x12\x1a\n\x12\x65od_exec_brkr_code\x18v \x01(\t\x12\x1a\n\x12\x65od_exec_bkkr_tags\x18w \x01(\t\x12=\n\x10\x63ls_hedge_window\x18x \x01(\x0e\x32#.spiderrock.protobuf.ClsHedgeWindow\x12%\n\x1d\x63ls_auction_sym_hedge_band_dD\x18y \x01(\x02\x12%\n\x1d\x63ls_auction_sym_hedge_band_gR\x18z \x01(\x02\x12\x1d\n\x15\x63ls_sym_hedge_band_dD\x18{ \x01(\x02\x12\x1d\n\x15\x63ls_sym_hedge_band_gR\x18| \x01(\x02\x12\x37\n\x13\x63ls_balance_symbols\x18} \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x39\n\x0e\x63ls_hedge_algo\x18~ \x01(\x0e\x32!.spiderrock.protobuf.ClsHedgeAlgo\x12\x1a\n\x12\x63ls_exec_brkr_algo\x18\x7f \x01(\t\x12\x1b\n\x12\x63ls_exec_brkr_code\x18\x80\x01 \x01(\t\x12\x1b\n\x12\x63ls_exec_bkkr_tags\x18\x81\x01 \x01(\t\x12\x14\n\x0bmodified_by\x18\x82\x01 \x01(\t\x12\x39\n\x0bmodified_in\x18\x83\x01 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12.\n\ttimestamp\x18\x84\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12N\n\x0bhedge_waves\x18g \x03(\x0b\x32\x39.spiderrock.protobuf.PositionHedgePolicyConfig.HedgeWaves\x1a\x64\n\x04PKey\x12\r\n\x05\x61\x63\x63nt\x18\n \x01(\t\x12\x13\n\x0b\x63lient_firm\x18\x0b \x01(\t\x12\x38\n\x06policy\x18\x0c \x01(\x0e\x32(.spiderrock.protobuf.PositionHedgePolicy\x1aq\n\nHedgeWaves\x12-\n\nhedge_time\x18h \x01(\x0b\x32\x19.google.protobuf.Duration\x12\x19\n\x11sym_hedge_band_dD\x18i \x01(\x02\x12\x19\n\x11sym_hedge_band_gR\x18j \x01(\x02\x62\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientControl.PositionHedgePolicyConfig_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_POSITIONHEDGEPOLICYCONFIG']._serialized_start=161
  _globals['_POSITIONHEDGEPOLICYCONFIG']._serialized_end=1764
  _globals['_POSITIONHEDGEPOLICYCONFIG_PKEY']._serialized_start=1549
  _globals['_POSITIONHEDGEPOLICYCONFIG_PKEY']._serialized_end=1649
  _globals['_POSITIONHEDGEPOLICYCONFIG_HEDGEWAVES']._serialized_start=1651
  _globals['_POSITIONHEDGEPOLICYCONFIG_HEDGEWAVES']._serialized_end=1764
# @@protoc_insertion_point(module_scope)
