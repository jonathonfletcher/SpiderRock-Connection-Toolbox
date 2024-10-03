# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientRisk/FuturePositionRecordV5.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n\'ClientRisk/FuturePositionRecordV5.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xe3\r\n\x16\x46uturePositionRecordV5\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12>\n\x04pkey\x18\x02 \x01(\x0b\x32\x30.spiderrock.protobuf.FuturePositionRecordV5.PKey\x12\x18\n\x10risk_server_code\x18g \x01(\t\x12\x11\n\tagg_group\x18j \x01(\t\x12.\n\x06ticker\x18m \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\x19\n\x11underliers_per_cn\x18p \x01(\x05\x12:\n\x0eunderlier_type\x18s \x01(\x0e\x32\".spiderrock.protobuf.UnderlierType\x12\x12\n\ntick_value\x18v \x01(\x02\x12\x13\n\x0bpoint_value\x18y \x01(\x02\x12\x35\n\x0epoint_currency\x18| \x01(\x0e\x32\x1d.spiderrock.protobuf.Currency\x12\x36\n\x0cprice_format\x18\x7f \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x10\n\x07\x66ut_prc\x18\x82\x01 \x01(\x01\x12\x10\n\x07\x66ut_bid\x18\x85\x01 \x01(\x01\x12\x10\n\x07\x66ut_ask\x18\x88\x01 \x01(\x01\x12\x11\n\x08\x66ut_mark\x18\x8b\x01 \x01(\x01\x12?\n\x12\x66ut_mark_err_codes\x18\x8e\x01 \x01(\x0e\x32\".spiderrock.protobuf.MarkErrorCode\x12:\n\x0f\x66ut_mark_source\x18\x91\x01 \x01(\x0e\x32 .spiderrock.protobuf.UMarkSource\x12\x19\n\x10\x66ut_opn_mid_mark\x18\x94\x01 \x01(\x01\x12\x19\n\x10\x66ut_opn_clr_mark\x18\x97\x01 \x01(\x01\x12\x18\n\x0f\x66ut_opn_pos_prv\x18\x9a\x01 \x01(\x05\x12\x18\n\x0f\x66ut_opn_pos_clr\x18\x9d\x01 \x01(\x05\x12\x14\n\x0b\x66ut_opn_pos\x18\xa0\x01 \x01(\x05\x12=\n\x0f\x66ut_opn_pos_src\x18\xa3\x01 \x01(\x0e\x32#.spiderrock.protobuf.PositionSource\x12\x0f\n\x06\x63n_bot\x18\xa6\x01 \x01(\x05\x12\x0f\n\x06\x63n_sld\x18\xa9\x01 \x01(\x05\x12\x13\n\ncn_bot_trd\x18\xac\x01 \x01(\x05\x12\x13\n\ncn_sld_trd\x18\xaf\x01 \x01(\x05\x12\x13\n\ncn_bot_hdg\x18\xb2\x01 \x01(\x05\x12\x13\n\ncn_sld_hdg\x18\xb5\x01 \x01(\x05\x12\x13\n\ncn_bot_trh\x18\xb8\x01 \x01(\x05\x12\x13\n\ncn_sld_trh\x18\xbb\x01 \x01(\x05\x12\x13\n\ncn_bot_opn\x18\xbe\x01 \x01(\x05\x12\x13\n\ncn_sld_opn\x18\xc1\x01 \x01(\x05\x12\x12\n\tcn_opened\x18\xc4\x01 \x01(\x05\x12\x12\n\tcn_closed\x18\xc7\x01 \x01(\x05\x12\x14\n\x0b\x66ut_mny_bot\x18\xca\x01 \x01(\x01\x12\x14\n\x0b\x66ut_mny_sld\x18\xcd\x01 \x01(\x01\x12\x10\n\x07\x64\x61y_pnl\x18\xd0\x01 \x01(\x02\x12\x19\n\x10opn_pnl_mid_mark\x18\xd3\x01 \x01(\x02\x12\x19\n\x10opn_pnl_clr_mark\x18\xd6\x01 \x01(\x02\x12\r\n\x04\x62\x65ta\x18\xd9\x01 \x01(\x02\x12\x35\n\x0b\x62\x65ta_source\x18\xdc\x01 \x01(\x0e\x32\x1f.spiderrock.protobuf.BetaSource\x12\r\n\x04\x64\x61ys\x18\xdf\x01 \x01(\x05\x12\r\n\x04rate\x18\xe2\x01 \x01(\x02\x12\x0e\n\x05years\x18\xe5\x01 \x01(\x02\x12\x0b\n\x02rh\x18\xe8\x01 \x01(\x02\x12\x0b\n\x02ve\x18\xeb\x01 \x01(\x02\x12\x10\n\x07rate_pr\x18\xee\x01 \x01(\x02\x12\x11\n\x08years_pr\x18\xf1\x01 \x01(\x02\x12\x13\n\nmargin_uDn\x18\xfb\x01 \x01(\x02\x12\x13\n\nmargin_uUp\x18\xfc\x01 \x01(\x02\x12\x17\n\x0enum_executions\x18\xf4\x01 \x01(\x05\x12\x32\n\rmax_exec_dttm\x18\xf7\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12.\n\ttimestamp\x18\xfa\x01 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\xc2\x01\n\x04PKey\x12,\n\x04\x66key\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\r\n\x05\x61\x63\x63nt\x18\x0b \x01(\t\x12\x30\n\ntrade_date\x18\x0c \x01(\x0b\x32\x1c.spiderrock.protobuf.DateKey\x12\x36\n\x0crisk_session\x18\r \x01(\x0e\x32 .spiderrock.protobuf.RiskSession\x12\x13\n\x0b\x63lient_firm\x18\x0e \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientRisk.FuturePositionRecordV5_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_FUTUREPOSITIONRECORDV5']._serialized_start=123
  _globals['_FUTUREPOSITIONRECORDV5']._serialized_end=1886
  _globals['_FUTUREPOSITIONRECORDV5_PKEY']._serialized_start=1692
  _globals['_FUTUREPOSITIONRECORDV5_PKEY']._serialized_end=1886
# @@protoc_insertion_point(module_scope)