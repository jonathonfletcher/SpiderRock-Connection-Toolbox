# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: OptSurface/LiveAtmVol.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\x1bOptSurface/LiveAtmVol.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\x9b\x08\n\nLiveAtmVol\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x32\n\x04pkey\x18\x02 \x01(\x0b\x32$.spiderrock.protobuf.LiveAtmVol.PKey\x12.\n\x06ticker\x18\x64 \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\r\n\x05u_prc\x18g \x01(\x01\x12\r\n\x05years\x18j \x01(\x02\x12\x0c\n\x04rate\x18m \x01(\x02\x12\x0c\n\x04\x64\x64iv\x18p \x01(\x02\x12\x0f\n\x07\x64\x64iv_pv\x18s \x01(\x02\x12\x34\n\x0b\x64\x64iv_source\x18v \x01(\x0e\x32\x1f.spiderrock.protobuf.DDivSource\x12\x0f\n\x07\x61tm_vol\x18y \x01(\x02\x12\x0f\n\x07\x61tm_eMA\x18| \x01(\x02\x12\x13\n\x0bu_prc_ratio\x18\x7f \x01(\x01\x12\x18\n\x0fu_prc_ratio_eMA\x18\x82\x01 \x01(\x01\x12\r\n\x04sdiv\x18\x85\x01 \x01(\x02\x12\x11\n\x08sdiv_eMA\x18\x88\x01 \x01(\x02\x12\x16\n\rmin_cPAdj_val\x18\x8b\x01 \x01(\x01\x12\x16\n\rmax_cPAdj_val\x18\x8e\x01 \x01(\x01\x12\x34\n\x0b\x63p_adj_type\x18\x91\x01 \x01(\x0e\x32\x1e.spiderrock.protobuf.CPAdjType\x12\x37\n\nprice_type\x18\x94\x01 \x01(\x0e\x32\".spiderrock.protobuf.CalcPriceType\x12\x39\n\x10u_prc_driver_key\x18\x97\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12<\n\x11u_prc_driver_type\x18\x9a\x01 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x15\n\x0cu_prc_driver\x18\x9d\x01 \x01(\x01\x12\x13\n\naxis_fUPrc\x18\xa0\x01 \x01(\x02\x12\x11\n\x08syn_spot\x18\xa3\x01 \x01(\x01\x12\x10\n\x07v_width\x18\xa6\x01 \x01(\x02\x12\x18\n\x0fnum_atm_strikes\x18\xa9\x01 \x01(\x05\x12?\n\x10tradeable_status\x18\xac\x01 \x01(\x0e\x32$.spiderrock.protobuf.TradeableStatus\x12>\n\x0esurface_result\x18\xaf\x01 \x01(\x0e\x32%.spiderrock.protobuf.SurfaceAdjResult\x12\x16\n\rnet_timestamp\x18\xb2\x01 \x01(\x03\x12.\n\ttimestamp\x18\xb5\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\x34\n\x04PKey\x12,\n\x04\x65key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKeyb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'OptSurface.LiveAtmVol_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_LIVEATMVOL']._serialized_start=111
  _globals['_LIVEATMVOL']._serialized_end=1162
  _globals['_LIVEATMVOL_PKEY']._serialized_start=1110
  _globals['_LIVEATMVOL_PKEY']._serialized_end=1162
# @@protoc_insertion_point(module_scope)
