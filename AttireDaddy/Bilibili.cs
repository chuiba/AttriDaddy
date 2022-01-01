using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Newtonsoft.Json;
using RestSharp;

namespace AttireDaddy
{
    public class SurplusDesc
    {
        /// <summary>
        /// 我才不是恶魔，换上炎炎专属装扮一起来成为英雄吧！本套装包括头像挂件、动态卡片、点赞动效和表情包，永久购买还能成为认证粉丝，领取粉丝专属装扮！
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 炎炎消防队动画
        /// </summary>
        public string fan_desc { get; set; }
        /// <summary>
        /// 炎炎消防队动画
        /// </summary>
        public string fan_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_item_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_mid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_no_color { get; set; }
        /// <summary>
        /// 与火焰的恐怖对抗的「特殊消防队」的使命是解开人体自燃现象之谜并拯救人类！以成为「英雄」为目标，少年森罗与同伴们一起投身于与「焰人」对抗的日子中！超燃呈现！
        /// </summary>
        public string fan_recommend_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_recommend_jump_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_recommend_jump_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_share_image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover_long { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id_card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id_emoji { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id_pendant { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id_thumbup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rank_investor_show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_bp_forever_raw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_bp_pm_raw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_buy_num_limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_quantity_limit { get; set; }
        /// <summary>
        /// 全球
        /// </summary>
        public string sale_region_ip_limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_reserve_switch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_time_begin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
    }

    public class Current_activity
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string time_limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int time_left { get; set; }
        /// <summary>
        /// 限时折扣
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int price_bp_month { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int price_bp_forever { get; set; }
    }

    public class Item
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队动画
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Current_activity current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
    }

    public class SurplusImage
    {
        /// <summary>
        /// 
        /// </summary>
        public string hot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_preview_big { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_preview_small { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
    }

    public class CardItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class SurplusSaleImage
    {
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_preview_small { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
    }

    public class Card_bgItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队动画
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class SurplusBiz
    {
        /// <summary>
        /// 
        /// </summary>
        public string addable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string biz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_ids { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string permanent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string recently_used { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string recommend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string removable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string setting_pannel_not_show { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sortable { get; set; }
    }

    public class SurplusSale
    {
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_symbol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string non_associate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
    }

    public class ItemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// [炎炎消防队_点点点]
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
    }

    public class Emoji_packageItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
    }

    public class SurplusGrab
    {
        /// <summary>
        /// 
        /// </summary>
        public string garb_avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sale_type { get; set; }
    }

    public class PendantItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class SurplusColor
    {
        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string color_mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string color_second_page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string head_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string head_myself_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string head_myself_mp4_play { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string head_myself_squared_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string head_tab_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_preview { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string package_md5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string package_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string side_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string side_bg_bottom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string side_bg_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_color_selected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_ani { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_ani_mode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_channel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_dynamic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_main { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_myself { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_selected_channel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_selected_dynamic { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_selected_main { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_selected_myself { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_selected_shop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tail_icon_shop { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ver { get; set; }
    }

    public class SkinItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队动画
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class SurplusFan
    {
        /// <summary>
        /// 
        /// </summary>
        public string fan_no_color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fan_no_image { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image1_landscape { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image1_portrait { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image2_landscape { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image2_portrait { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image3_landscape { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image3_portrait { get; set; }
    }

    public class Space_bgItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class Properties
    {
        /// <summary>
        /// 
        /// </summary>
        public string image_ani { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_ani_cut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_preview { get; set; }

        public int sale_quantity { get; set; }
    }

    public class ThumbupItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 炎炎消防队
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tab_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int suit_item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_activity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string current_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string finish_sources { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_time_end { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string items { get; set; }
    }

    public class Suit_items
    {
        /// <summary>
        /// 
        /// </summary>
        public List<CardItem> card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Card_bgItem> card_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Emoji_packageItem> emoji_package { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PendantItem> pendant { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SkinItem> skin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Space_bgItem> space_bg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ThumbupItem> thumbup { get; set; }
    }

    public class Fan_user
    {
        /// <summary>
        /// 
        /// </summary>
        public int mid { get; set; }
        /// <summary>
        /// 炎炎消防队_official
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
    }

    public class Activity_entrance
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int item_id { get; set; }
        /// <summary>
        /// 个性装扮特别款周边
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string image_cover { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string jump_link { get; set; }
    }

    public class SurplusData
    {
        /// <summary>
        /// 
        /// </summary>
        public Item item { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_surplus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sale_left_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Suit_items suit_items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Fan_user fan_user { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unlock_items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Activity_entrance activity_entrance { get; set; }
    }

    public class Surplus
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ttl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SurplusData data { get; set; }
    }

    public class RankItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int mid { get; set; }
        /// <summary>
        /// 阿伟还活着x
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int number { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public List<RankItem> rank { get; set; }
    }

    public class Recent
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ttl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
    }



    /// <summary>
    /// 提供了对 Bilibili 的数据解析
    /// </summary>
    class Bilibili
    {
        private RestClient client;





        public Surplus getSurplus(int id)
        {
            try
            {
                var request = new RestRequest($"x/garb/mall/item/suit/v2?item_id={id}&part=suit", Method.GET);
                IRestResponse response = client.Execute(request);
                var contentGet = response.Content;
                // Console.WriteLine("GET方式获取结果：" + contentGet);

                Surplus surplus = JsonConvert.DeserializeObject<Surplus>(contentGet);
                // Console.WriteLine(surplus.data.sale_surplus);

                return surplus;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }

       

        public Recent getRecent(int id)
        {
            try
            {
                var request = new RestRequest($"x/garb/rank/fan/recent?item_id={id}", Method.GET);
                IRestResponse response = client.Execute(request);
                var contentGet = response.Content;
                // Console.WriteLine("GET方式获取结果：" + contentGet);

                Recent recent = JsonConvert.DeserializeObject<Recent>(contentGet);
                return recent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return null;
        }


        public Bilibili()
        {
            client = new RestClient("https://api.bilibili.com");
            client.Timeout = 5000; // 5000 milliseconds == 5 seconds
        }

        ~Bilibili()
        {

        }
    }
}
