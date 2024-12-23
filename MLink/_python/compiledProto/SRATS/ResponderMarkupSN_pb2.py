# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: SRATS/ResponderMarkupSN.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1dSRATS/ResponderMarkupSN.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xf9\t\n\x11ResponderMarkupSN\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x39\n\x04pkey\x18\x02 \x01(\x0b\x32+.spiderrock.protobuf.ResponderMarkupSN.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12/\n\x0bis_disabled\x18\x65 \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x18\n\x10\x65xpiry_qty_avail\x18\x66 \x01(\x05\x12\x18\n\x10ticker_qty_avail\x18g \x01(\x05\x12\x37\n\rref_uPrc_type\x18h \x01(\x0e\x32 .spiderrock.protobuf.RefUPrcType\x12\x14\n\x0ctransact_fee\x18i \x01(\x01\x12\x12\n\nstock_rate\x18j \x01(\x01\x12\x12\n\nmoney_rate\x18k \x01(\x01\x12\x0f\n\x07\x64\x64iv_pv\x18l \x01(\x01\x12\x34\n\x0b\x64iv_control\x18m \x01(\x0e\x32\x1f.spiderrock.protobuf.DivControl\x12\x34\n\x10inc_fees_in_resp\x18n \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x32\n\nround_rule\x18o \x01(\x0e\x32\x1e.spiderrock.protobuf.RoundRule\x12\x17\n\x0fopen_expiry_qty\x18p \x01(\x05\x12\x17\n\x0fopen_ticker_qty\x18q \x01(\x05\x12\x16\n\x0e\x63um_expiry_qty\x18r \x01(\x05\x12\x18\n\x10\x63um_expiry_money\x18s \x01(\x01\x12\x18\n\x10\x61vg_expiry_price\x18t \x01(\x01\x12;\n\x17is_div_control_disabled\x18u \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\r\n\x05u_bid\x18v \x01(\x01\x12\r\n\x05u_ask\x18w \x01(\x01\x12\x0e\n\x06i_days\x18x \x01(\x01\x12\x0f\n\x07i_years\x18y \x01(\x01\x12\x0e\n\x06strike\x18z \x01(\x01\x12\x11\n\tstrike_pv\x18{ \x01(\x01\x12\x15\n\rstock_lend_pv\x18| \x01(\x01\x12\x16\n\x0esynthetic_prem\x18} \x01(\x01\x12\x1b\n\x13\x65\x66\x66_synthetic_limit\x18~ \x01(\x01\x12\x13\n\x0blimit_price\x18\x7f \x01(\x01\x12\x14\n\x0bmodified_by\x18\x80\x01 \x01(\t\x12\x39\n\x0bmodified_in\x18\x81\x01 \x01(\x0e\x32#.spiderrock.protobuf.SysEnvironment\x12.\n\ttimestamp\x18\x82\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\xb7\x01\n\x04PKey\x12\r\n\x05\x61\x63\x63nt\x18\n \x01(\t\x12\x13\n\x0b\x63lient_firm\x18\x0b \x01(\t\x12,\n\x04root\x18\x0c \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12,\n\x06\x65xpiry\x18\r \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12/\n\tresp_side\x18\x0e \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySellb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'SRATS.ResponderMarkupSN_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_RESPONDERMARKUPSN']._serialized_start=113
  _globals['_RESPONDERMARKUPSN']._serialized_end=1386
  _globals['_RESPONDERMARKUPSN_PKEY']._serialized_start=1203
  _globals['_RESPONDERMARKUPSN_PKEY']._serialized_end=1386
# @@protoc_insertion_point(module_scope)
