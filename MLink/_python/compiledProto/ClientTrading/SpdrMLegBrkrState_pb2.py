# -*- coding: utf-8 -*-
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: ClientTrading/SpdrMLegBrkrState.proto
"""Generated protocol buffer code."""
from google.protobuf.internal import builder as _builder
from google.protobuf import descriptor as _descriptor
from google.protobuf import descriptor_pool as _descriptor_pool
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import spiderrock_common_pb2 as spiderrock__common__pb2
from google.protobuf import timestamp_pb2 as google_dot_protobuf_dot_timestamp__pb2


DESCRIPTOR = _descriptor_pool.Default().AddSerializedFile(b'\n%ClientTrading/SpdrMLegBrkrState.proto\x12\x13spiderrock.protobuf\x1a\x17spiderrock_common.proto\x1a\x1fgoogle/protobuf/timestamp.proto\"\xffM\n\x11SpdrMLegBrkrState\x12\x33\n\x05_meta\x18\x01 \x01(\x0b\x32$.spiderrock.protobuf.MessageMetadata\x12\x39\n\x04pkey\x18\x02 \x01(\x0b\x32+.spiderrock.protobuf.SpdrMLegBrkrState.PKey\x12\x14\n\x0b\x65ngine_name\x18\x8d\x08 \x01(\t\x12\x15\n\rparent_number\x18g \x01(\x03\x12\x1a\n\x12\x62\x61se_parent_number\x18j \x01(\x03\x12\x16\n\rmodify_number\x18\x8e\x08 \x01(\x03\x12\x14\n\x0c\x61lt_order_id\x18m \x01(\t\x12\x12\n\npackage_id\x18p \x01(\x03\x12\x11\n\talt_accnt\x18v \x01(\t\x12\x15\n\ralt_user_name\x18y \x01(\t\x12\x36\n\nstage_type\x18| \x01(\x0e\x32\".spiderrock.protobuf.SpdrStageType\x12\x33\n\nstart_type\x18\x8f\x08 \x01(\x0e\x32\x1e.spiderrock.protobuf.StartType\x12.\n\nis_flagged\x18\x7f \x01(\x0e\x32\x1a.spiderrock.protobuf.YesNo\x12\x16\n\rnotice_number\x18\x9c\x08 \x01(\x03\x12\x17\n\x0e\x65xec_brkr_code\x18\x9e\x08 \x01(\t\x12;\n\x0cspread_class\x18\x92\x08 \x01(\x0e\x32$.spiderrock.protobuf.ToolSpreadClass\x12\x39\n\rspread_flavor\x18\x93\x08 \x01(\x0e\x32!.spiderrock.protobuf.SpreadFlavor\x12\x31\n\nstock_side\x18\x85\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x37\n\nssale_flag\x18\x88\x01 \x01(\x0e\x32\".spiderrock.protobuf.ShortSaleFlag\x12\x14\n\x0blocate_quan\x18\x8b\x01 \x01(\x05\x12\x14\n\x0blocate_firm\x18\x8e\x01 \x01(\t\x12\x14\n\x0blocate_pool\x18\x91\x01 \x01(\t\x12\x15\n\x0cstock_shares\x18\x94\x01 \x01(\x05\x12\x15\n\x0cstock_leg_id\x18\x97\x01 \x01(\x03\x12\x18\n\x0fstock_fill_quan\x18\x9a\x01 \x01(\x05\x12\x1d\n\x14stock_avg_fill_price\x18\x9d\x01 \x01(\x01\x12\x11\n\x08ref_uPrc\x18\xa0\x01 \x01(\x02\x12\x12\n\tlive_uPrc\x18\xa3\x01 \x01(\x02\x12\x39\n\x0eu_price_format\x18\xa6\x01 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x12\n\tstock_cpx\x18\xa9\x01 \x01(\x02\x12\x12\n\tstock_csz\x18\xac\x01 \x01(\x05\x12\x12\n\tstock_cex\x18\xaf\x01 \x01(\r\x12\x11\n\x08num_legs\x18\xb2\x01 \x01(\x05\x12\x31\n\x08sec_key1\x18\xb5\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type1\x18\xb8\x01 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio1\x18\xbb\x01 \x01(\r\x12,\n\x05side1\x18\xbe\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type1\x18\xc1\x01 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id1\x18\xc4\x01 \x01(\x03\x12\x13\n\nfill_quan1\x18\xc7\x01 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price1\x18\xca\x01 \x01(\x01\x12\x0e\n\x05vega1\x18\xcd\x01 \x01(\x02\x12\x12\n\tref_uPrc1\x18\xd0\x01 \x01(\x01\x12\x13\n\nref_delta1\x18\xd3\x01 \x01(\x02\x12\x16\n\rref_earn_cnt1\x18\xd6\x01 \x01(\x05\x12\x13\n\nlive_uPrc1\x18\xd9\x01 \x01(\x01\x12\x38\n\rprice_format1\x18\xdc\x01 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx1\x18\xdf\x01 \x01(\x02\x12\x11\n\x08leg_csz1\x18\xe2\x01 \x01(\x05\x12\x11\n\x08leg_cex1\x18\xe5\x01 \x01(\r\x12\x31\n\x08sec_key2\x18\xe8\x01 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type2\x18\xeb\x01 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio2\x18\xee\x01 \x01(\r\x12,\n\x05side2\x18\xf1\x01 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type2\x18\xf4\x01 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id2\x18\xf7\x01 \x01(\x03\x12\x13\n\nfill_quan2\x18\xfa\x01 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price2\x18\xfd\x01 \x01(\x01\x12\x0e\n\x05vega2\x18\x80\x02 \x01(\x02\x12\x12\n\tref_uPrc2\x18\x83\x02 \x01(\x01\x12\x13\n\nref_delta2\x18\x86\x02 \x01(\x02\x12\x16\n\rref_earn_cnt2\x18\x89\x02 \x01(\x05\x12\x13\n\nlive_uPrc2\x18\x8c\x02 \x01(\x01\x12\x38\n\rprice_format2\x18\x8f\x02 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx2\x18\x92\x02 \x01(\x02\x12\x11\n\x08leg_csz2\x18\x95\x02 \x01(\x05\x12\x11\n\x08leg_cex2\x18\x98\x02 \x01(\r\x12\x31\n\x08sec_key3\x18\x9b\x02 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type3\x18\x9e\x02 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio3\x18\xa1\x02 \x01(\r\x12,\n\x05side3\x18\xa4\x02 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type3\x18\xa7\x02 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id3\x18\xaa\x02 \x01(\x03\x12\x13\n\nfill_quan3\x18\xad\x02 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price3\x18\xb0\x02 \x01(\x01\x12\x0e\n\x05vega3\x18\xb3\x02 \x01(\x02\x12\x12\n\tref_uPrc3\x18\xb6\x02 \x01(\x01\x12\x13\n\nref_delta3\x18\xb9\x02 \x01(\x02\x12\x16\n\rref_earn_cnt3\x18\xbc\x02 \x01(\x05\x12\x13\n\nlive_uPrc3\x18\xbf\x02 \x01(\x01\x12\x38\n\rprice_format3\x18\xc2\x02 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx3\x18\xc5\x02 \x01(\x02\x12\x11\n\x08leg_csz3\x18\xc8\x02 \x01(\x05\x12\x11\n\x08leg_cex3\x18\xcb\x02 \x01(\r\x12\x31\n\x08sec_key4\x18\xce\x02 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type4\x18\xd1\x02 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio4\x18\xd4\x02 \x01(\r\x12,\n\x05side4\x18\xd7\x02 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type4\x18\xda\x02 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id4\x18\xdd\x02 \x01(\x03\x12\x13\n\nfill_quan4\x18\xe0\x02 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price4\x18\xe3\x02 \x01(\x01\x12\x0e\n\x05vega4\x18\xe6\x02 \x01(\x02\x12\x12\n\tref_uPrc4\x18\xe9\x02 \x01(\x01\x12\x13\n\nref_delta4\x18\xec\x02 \x01(\x02\x12\x16\n\rref_earn_cnt4\x18\xef\x02 \x01(\x05\x12\x13\n\nlive_uPrc4\x18\xf2\x02 \x01(\x01\x12\x38\n\rprice_format4\x18\xf5\x02 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx4\x18\xf8\x02 \x01(\x02\x12\x11\n\x08leg_csz4\x18\xfb\x02 \x01(\x05\x12\x11\n\x08leg_cex4\x18\xfe\x02 \x01(\r\x12\x31\n\x08sec_key5\x18\x81\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type5\x18\x84\x03 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio5\x18\x87\x03 \x01(\r\x12,\n\x05side5\x18\x8a\x03 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type5\x18\x8d\x03 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id5\x18\x90\x03 \x01(\x03\x12\x13\n\nfill_quan5\x18\x93\x03 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price5\x18\x96\x03 \x01(\x01\x12\x0e\n\x05vega5\x18\x99\x03 \x01(\x02\x12\x12\n\tref_uPrc5\x18\x9c\x03 \x01(\x01\x12\x13\n\nref_delta5\x18\x9f\x03 \x01(\x02\x12\x16\n\rref_earn_cnt5\x18\xa2\x03 \x01(\x05\x12\x13\n\nlive_uPrc5\x18\xa5\x03 \x01(\x01\x12\x38\n\rprice_format5\x18\xa8\x03 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx5\x18\xab\x03 \x01(\x02\x12\x11\n\x08leg_csz5\x18\xae\x03 \x01(\x05\x12\x11\n\x08leg_cex5\x18\xb1\x03 \x01(\r\x12\x31\n\x08sec_key6\x18\xb4\x03 \x01(\x0b\x32\x1e.spiderrock.protobuf.OptionKey\x12\x34\n\tsec_type6\x18\xb7\x03 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x0f\n\x06ratio6\x18\xba\x03 \x01(\r\x12,\n\x05side6\x18\xbd\x03 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12:\n\x0eposition_type6\x18\xc0\x03 \x01(\x0e\x32!.spiderrock.protobuf.PositionType\x12\x10\n\x07leg_id6\x18\xc3\x03 \x01(\x03\x12\x13\n\nfill_quan6\x18\xc6\x03 \x01(\x05\x12\x18\n\x0f\x61vg_fill_price6\x18\xc9\x03 \x01(\x01\x12\x0e\n\x05vega6\x18\xcc\x03 \x01(\x02\x12\x12\n\tref_uPrc6\x18\xcf\x03 \x01(\x01\x12\x13\n\nref_delta6\x18\xd2\x03 \x01(\x02\x12\x16\n\rref_earn_cnt6\x18\xd5\x03 \x01(\x05\x12\x13\n\nlive_uPrc6\x18\xd8\x03 \x01(\x01\x12\x38\n\rprice_format6\x18\xdb\x03 \x01(\x0e\x32 .spiderrock.protobuf.PriceFormat\x12\x11\n\x08leg_cpx6\x18\xde\x03 \x01(\x02\x12\x11\n\x08leg_csz6\x18\xe1\x03 \x01(\x05\x12\x11\n\x08leg_cex6\x18\xe4\x03 \x01(\r\x12\x12\n\tmleg_vega\x18\xe7\x03 \x01(\x02\x12\x15\n\x0cmleg_wt_vega\x18\xea\x03 \x01(\x02\x12\x13\n\nmleg_delta\x18\xed\x03 \x01(\x02\x12\x13\n\nmleg_gamma\x18\xf0\x03 \x01(\x02\x12\x13\n\nmleg_theta\x18\xf3\x03 \x01(\x02\x12\x14\n\x0b\x64\x65scription\x18\xf6\x03 \x01(\t\x12\x13\n\norder_size\x18\xf9\x03 \x01(\x05\x12\x1a\n\x11order_active_size\x18\xfc\x03 \x01(\x05\x12\x18\n\x0fleaves_quantity\x18\xff\x03 \x01(\x05\x12@\n\x11spdr_order_status\x18\x82\x04 \x01(\x0e\x32$.spiderrock.protobuf.SpdrOrderStatus\x12@\n\x11spdr_close_reason\x18\x85\x04 \x01(\x0e\x32$.spiderrock.protobuf.SpdrCloseReason\x12\x42\n\x12spdr_reject_reason\x18\x88\x04 \x01(\x0e\x32%.spiderrock.protobuf.SpdrRejectReason\x12\x1e\n\x15spdr_close_detail_txt\x18\x8b\x04 \x01(\t\x12\x12\n\topen_legs\x18\x8e\x04 \x01(\x05\x12\x17\n\x0e\x63um_square_qty\x18\x91\x04 \x01(\x05\x12\x17\n\x0e\x61vg_square_prc\x18\x94\x04 \x01(\x01\x12\x18\n\x0f\x63um_partial_qty\x18\x97\x04 \x01(\x05\x12\x12\n\tfill_vega\x18\x9a\x04 \x01(\x02\x12\x15\n\x0c\x66ill_wt_vega\x18\x9d\x04 \x01(\x02\x12\x13\n\nfill_delta\x18\xa0\x04 \x01(\x02\x12\x14\n\x0b\x66ill_dDelta\x18\xa3\x04 \x01(\x02\x12\x13\n\nfill_gamma\x18\xa6\x04 \x01(\x02\x12\x13\n\nfill_theta\x18\xa9\x04 \x01(\x02\x12\x33\n\x0elast_fill_dttm\x18\xac\x04 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x18\n\x0frisk_limit_size\x18\xaf\x04 \x01(\x05\x12\x37\n\x0frisk_limit_desc\x18\xb2\x04 \x01(\x0e\x32\x1d.spiderrock.protobuf.SpdrRisk\x12=\n\x10risk_limit_level\x18\x94\x08 \x01(\x0e\x32\".spiderrock.protobuf.SpdrRiskLevel\x12\x37\n\x0cmax_progress\x18\xb5\x04 \x01(\x0e\x32 .spiderrock.protobuf.MaxProgress\x12\x1c\n\x13max_progress_detail\x18\xb8\x04 \x01(\t\x12\x36\n\x11max_progress_time\x18\xbb\x04 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x33\n\nalgo_state\x18\xbe\x04 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12\x15\n\x0c\x61lgo_counter\x18\xc1\x04 \x01(\x05\x12\x33\n\nmake_state\x18\xc4\x04 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlgoState\x12\x15\n\x0cmake_counter\x18\xc7\x04 \x01(\x05\x12:\n\x0emkt_resp_state\x18\xca\x04 \x01(\x0e\x32!.spiderrock.protobuf.MktRespState\x12\x19\n\x10mkt_resp_counter\x18\xcd\x04 \x01(\x05\x12\x37\n\x0c\x62roker_state\x18\xd0\x04 \x01(\x0e\x32 .spiderrock.protobuf.BrokerState\x12\x17\n\x0e\x62roker_counter\x18\xd3\x04 \x01(\x05\x12=\n\x0espdr_mkt_state\x18\xd6\x04 \x01(\x0e\x32$.spiderrock.protobuf.SpdrMarketState\x12\x42\n\x12spdr_broker_status\x18\xd9\x04 \x01(\x0e\x32%.spiderrock.protobuf.SpdrBrokerStatus\x12\x1d\n\x14progress_rule_detail\x18\xdc\x04 \x01(\t\x12;\n\x16last_child_reject_dttm\x18\xdf\x04 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x1f\n\x16last_child_reject_text\x18\xe2\x04 \x01(\t\x12\x16\n\rrisk_group_id\x18\xe5\x04 \x01(\x03\x12\x19\n\x10trigger_group_id\x18\xe8\x04 \x01(\x03\x12\x1c\n\x13hedge_grouping_code\x18\xeb\x04 \x01(\x03\x12\x33\n\nauto_hedge\x18\xee\x04 \x01(\x0e\x32\x1e.spiderrock.protobuf.AutoHedge\x12\x39\n\x10hedge_instrument\x18\xf1\x04 \x01(\x0e\x32\x1e.spiderrock.protobuf.HedgeInst\x12\x36\n\rhedge_sec_key\x18\xf4\x04 \x01(\x0b\x32\x1e.spiderrock.protobuf.ExpiryKey\x12\x39\n\x0ehedge_sec_type\x18\xf7\x04 \x01(\x0e\x32 .spiderrock.protobuf.SpdrKeyType\x12\x19\n\x10hedge_beta_ratio\x18\xfa\x04 \x01(\x02\x12\x35\n\x0bhedge_scope\x18\xfd\x04 \x01(\x0e\x32\x1f.spiderrock.protobuf.HedgeScope\x12\x1d\n\x14\x65xtern_hedge_ex_dest\x18\x80\x05 \x01(\t\x12\x1c\n\x13\x65xtern_hedge_params\x18\x83\x05 \x01(\t\x12\x15\n\x0c\x62\x65st_way_prc\x18\x86\x05 \x01(\x02\x12\x15\n\x0cwrst_way_prc\x18\x89\x05 \x01(\x02\x12\x14\n\x0b\x62\x65st_way_sz\x18\x8c\x05 \x01(\x05\x12\x14\n\x0bwrst_way_sz\x18\x8f\x05 \x01(\x05\x12\x14\n\x0bsurface_prc\x18\x92\x05 \x01(\x02\x12\x14\n\x0bsurface_vol\x18\x95\x05 \x01(\x02\x12\x15\n\x0csurface_uPrc\x18\x98\x05 \x01(\x02\x12\x14\n\x0blimit_price\x18\x9b\x05 \x01(\x01\x12\x17\n\x0elimit_ref_uPrc\x18\x9d\x08 \x01(\x01\x12\x33\n\tlimit_err\x18\x9e\x05 \x01(\x0e\x32\x1f.spiderrock.protobuf.LimitError\x12\x19\n\x10make_limit_price\x18\xa1\x05 \x01(\x01\x12\x19\n\x10take_limit_price\x18\xa4\x05 \x01(\x01\x12\x35\n\x0e\x63xl_uPrc_range\x18\xa7\x05 \x01(\x0e\x32\x1c.spiderrock.protobuf.UPrcCxl\x12\x11\n\x08min_uBid\x18\xaa\x05 \x01(\x02\x12\x11\n\x08max_uAsk\x18\xad\x05 \x01(\x02\x12\x36\n\x0cmin_max_type\x18\xb0\x05 \x01(\x0e\x32\x1f.spiderrock.protobuf.MinMaxType\x12\x30\n\tlead_side\x18\xb3\x05 \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12 \n\x17max_completion_slippage\x18\xb6\x05 \x01(\x01\x12\x1a\n\x11order_ref_premium\x18\xb9\x05 \x01(\x02\x12\x11\n\x08strategy\x18\xbc\x05 \x01(\t\x12\x12\n\tuser_name\x18\xbf\x05 \x01(\t\x12\x15\n\x0cspdr_comment\x18\xc5\x05 \x01(\t\x12\x38\n\x0ftake_reach_rule\x18\xc8\x05 \x01(\x0e\x32\x1e.spiderrock.protobuf.ReachRule\x12\x1a\n\x11max_exposure_size\x18\xcb\x05 \x01(\x05\x12\x1b\n\x12num_make_exchanges\x18\xce\x05 \x01(\x05\x12=\n\x0bpublic_size\x18\xd1\x05 \x01(\x0e\x32\'.spiderrock.protobuf.PublicSizeHandling\x12\x39\n\rprogress_rule\x18\xd4\x05 \x01(\x0e\x32!.spiderrock.protobuf.ProgressRule\x12\x1b\n\x12progress_slice_cnt\x18\xd7\x05 \x01(\x05\x12\x1d\n\x14progress_expose_time\x18\xda\x05 \x01(\x05\x12\x19\n\x10max_child_orders\x18\xdd\x05 \x01(\x05\x12\x12\n\texch_mask\x18\xe0\x05 \x01(\r\x12;\n\x0emarket_session\x18\x95\x08 \x01(\x0e\x32\".spiderrock.protobuf.MarketSession\x12/\n\nstart_dttm\x18\xe6\x05 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x17\n\x0eorder_duration\x18\xe9\x05 \x01(\x05\x12\x18\n\x0f\x61\x63tive_duration\x18\x96\x08 \x01(\x05\x12\x33\n\x0egood_till_dttm\x18\xec\x05 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x30\n\x0b\x65xpire_dttm\x18\x97\x08 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12H\n\x15parent_order_handling\x18\xef\x05 \x01(\x0e\x32(.spiderrock.protobuf.ParentOrderHandling\x12L\n\x17parent_balance_handling\x18\xf2\x05 \x01(\x0e\x32*.spiderrock.protobuf.ParentBalanceHandling\x12?\n\x10\x62lock_visibility\x18\xf5\x05 \x01(\x0e\x32$.spiderrock.protobuf.BlockVisibility\x12=\n\x10order_limit_type\x18\xf8\x05 \x01(\x0e\x32\".spiderrock.protobuf.SpdrLimitType\x12\x18\n\x0forder_prc_limit\x18\xfb\x05 \x01(\x01\x12\x17\n\x0eorder_ref_uPrc\x18\xfe\x05 \x01(\x01\x12\x15\n\x0corder_ref_de\x18\x81\x06 \x01(\x02\x12\x15\n\x0corder_ref_ga\x18\x84\x06 \x01(\x02\x12\x19\n\x10order_prc_offset\x18\x87\x06 \x01(\x01\x12>\n\x10take_limit_class\x18\x8a\x06 \x01(\x0e\x32#.spiderrock.protobuf.SpdrLimitClass\x12\x38\n\x0ftake_alpha_type\x18\x8d\x06 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlphaType\x12\x1a\n\x11take_alpha_factor\x18\x90\x06 \x01(\x02\x12\x1f\n\x16take_alpha_probability\x18\x93\x06 \x01(\x02\x12\x1d\n\x14take_surf_prc_offset\x18\x96\x06 \x01(\x01\x12\x1d\n\x14take_surf_vol_offset\x18\x99\x06 \x01(\x02\x12\x1d\n\x14take_surf_wid_offset\x18\x9c\x06 \x01(\x02\x12>\n\x10make_limit_class\x18\x9f\x06 \x01(\x0e\x32#.spiderrock.protobuf.SpdrLimitClass\x12\x38\n\x0fmake_alpha_type\x18\xa2\x06 \x01(\x0e\x32\x1e.spiderrock.protobuf.AlphaType\x12\x1a\n\x11make_alpha_factor\x18\xa5\x06 \x01(\x02\x12\x1f\n\x16make_alpha_probability\x18\xa8\x06 \x01(\x02\x12\x1d\n\x14make_surf_prc_offset\x18\xab\x06 \x01(\x01\x12\x1d\n\x14make_surf_vol_offset\x18\xae\x06 \x01(\x02\x12\x1d\n\x14make_surf_wid_offset\x18\xb1\x06 \x01(\x02\x12\x1d\n\x14order_ref_event_mult\x18\xb4\x06 \x01(\x02\x12\x39\n\x14order_ref_event_dttm\x18\xb7\x06 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x18\n\x0fmleg_prob_limit\x18\xba\x06 \x01(\x02\x12\x19\n\x10mleg_surf_offset\x18\xbd\x06 \x01(\x02\x12\x17\n\x0e\x65xtern_ex_dest\x18\xc0\x06 \x01(\t\x12/\n\norder_dttm\x18\xc3\x06 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x12\x15\n\x0cmin_surf_vol\x18\xc6\x06 \x01(\x02\x12\x15\n\x0cmax_surf_vol\x18\xc9\x06 \x01(\x02\x12\x15\n\x0cmin_surf_prc\x18\xcc\x06 \x01(\x02\x12\x15\n\x0cmax_surf_prc\x18\xcf\x06 \x01(\x02\x12\x16\n\rmin_surf_uPrc\x18\xd2\x06 \x01(\x02\x12\x16\n\rmax_surf_uPrc\x18\xd5\x06 \x01(\x02\x12\x16\n\rmin_qte_width\x18\xd8\x06 \x01(\x02\x12\x16\n\ravg_qte_width\x18\xdb\x06 \x01(\x02\x12\x16\n\rcnt_qte_width\x18\xde\x06 \x01(\x05\x12\x13\n\narrive_bid\x18\xe1\x06 \x01(\x01\x12\x13\n\narrive_ask\x18\xe4\x06 \x01(\x01\x12\x16\n\rtotal_seconds\x18\xe7\x06 \x01(\x02\x12\x18\n\x0fworking_seconds\x18\xea\x06 \x01(\x02\x12\x17\n\x0eprt_active_cnt\x18\xed\x06 \x01(\x05\x12\x17\n\x0eprt_qty_active\x18\xf0\x06 \x01(\x05\x12\x15\n\x0c\x63um_exch_fee\x18\xf3\x06 \x01(\x02\x12\x14\n\x0b\x63um_m10_pnl\x18\xf6\x06 \x01(\x02\x12\x18\n\x0f\x63um_arrival_pnl\x18\xf9\x06 \x01(\x02\x12\x14\n\x0bu_prc_drift\x18\xfc\x06 \x01(\x02\x12\x14\n\x0bs_vol_drift\x18\xff\x06 \x01(\x02\x12\x1e\n\x15max_grp_day_dDelta_ln\x18\xb2\x07 \x01(\x02\x12\x1e\n\x15max_grp_day_dDelta_sh\x18\xb5\x07 \x01(\x02\x12!\n\x18max_grp_day_contracts_ln\x18\xd3\x07 \x01(\x05\x12!\n\x18max_grp_day_contracts_sh\x18\xd6\x07 \x01(\x05\x12\"\n\x19max_grp_day_contracts_abs\x18\xd9\x07 \x01(\x05\x12\x1c\n\x13max_grp_day_vega_ln\x18\xbb\x07 \x01(\x02\x12\x1c\n\x13max_grp_day_vega_sh\x18\xbe\x07 \x01(\x02\x12\x1d\n\x14max_grp_day_vega_abs\x18\xc1\x07 \x01(\x02\x12\x1b\n\x12grp_day_vega_ratio\x18\xc4\x07 \x01(\x02\x12 \n\x17max_grp_day_rMetric1_ln\x18\x98\x08 \x01(\x02\x12 \n\x17max_grp_day_rMetric1_sh\x18\x99\x08 \x01(\x02\x12!\n\x18max_grp_day_rMetric1_abs\x18\x9a\x08 \x01(\x02\x12\x1f\n\x16grp_day_rMetric1_ratio\x18\x9b\x08 \x01(\x02\x12\r\n\x04\x63px1\x18\xe8\x07 \x01(\x02\x12\r\n\x04\x63sz1\x18\xeb\x07 \x01(\x05\x12\r\n\x04\x63\x65x1\x18\xee\x07 \x01(\r\x12\r\n\x04\x63px2\x18\xf1\x07 \x01(\x02\x12\r\n\x04\x63sz2\x18\xf4\x07 \x01(\x05\x12\r\n\x04\x63\x65x2\x18\xf7\x07 \x01(\r\x12\x0f\n\x06\x63_more\x18\xfa\x07 \x01(\x05\x12\x17\n\x0enum_new_orders\x18\xfd\x07 \x01(\x05\x12\x1a\n\x11num_parent_limits\x18\x80\x08 \x01(\r\x12\x13\n\nuser_data1\x18\x83\x08 \x01(\t\x12\x13\n\nuser_data2\x18\x86\x08 \x01(\t\x12\x14\n\x0bnum_updates\x18\x89\x08 \x01(\x05\x12.\n\ttimestamp\x18\x8c\x08 \x01(\x0b\x32\x1a.google.protobuf.Timestamp\x1a\xd9\x01\n\x04PKey\x12.\n\x06ticker\x18\n \x01(\x0b\x32\x1e.spiderrock.protobuf.TickerKey\x12\r\n\x05\x61\x63\x63nt\x18\x0b \x01(\t\x12\x34\n\x0bspdr_source\x18\x0c \x01(\x0e\x32\x1f.spiderrock.protobuf.SpdrSource\x12\x15\n\rgrouping_code\x18\r \x01(\x03\x12\x30\n\norder_side\x18\x0e \x01(\x0e\x32\x1c.spiderrock.protobuf.BuySell\x12\x13\n\x0b\x63lient_firm\x18\x0f \x01(\tb\x06proto3')

_globals = globals()
_builder.BuildMessageAndEnumDescriptors(DESCRIPTOR, _globals)
_builder.BuildTopDescriptorsAndMessages(DESCRIPTOR, 'ClientTrading.SpdrMLegBrkrState_pb2', _globals)
if _descriptor._USE_C_DESCRIPTORS == False:

  DESCRIPTOR._options = None
  _globals['_SPDRMLEGBRKRSTATE']._serialized_start=121
  _globals['_SPDRMLEGBRKRSTATE']._serialized_end=10104
  _globals['_SPDRMLEGBRKRSTATE_PKEY']._serialized_start=9887
  _globals['_SPDRMLEGBRKRSTATE_PKEY']._serialized_end=10104
# @@protoc_insertion_point(module_scope)