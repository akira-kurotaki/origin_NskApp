using NskAppModelLibrary.Models;
using Microsoft.EntityFrameworkCore;
using ModelLibrary.Context;

namespace NskAppModelLibrary.Context
{
    /// <summary>
    /// ベースアプリケーション向けDBコンテキスト
    /// </summary>
    public class NskAppContext : JigyoContext
    {
        public NskAppContext(string connectionString, string defaultSchema, int commandTimeout = 0) : 
            base(connectionString, defaultSchema, commandTimeout)
        {
        }

        public NskAppContext(string connectionString, string defaultSchema, string userId, string ipAddress, int commandTimeout = 0) : 
            base(connectionString, defaultSchema, userId, ipAddress, commandTimeout)
        {
        }

        /// <summary>
        /// 加入者情報
        /// </summary>
        public DbSet<TKanyusha> TKanyushas { get; set; }

        /// <summary>
        /// 一時連携加入者情報
        /// </summary>
        public DbSet<WRenkeiKanyusha> WRenkeiKanyushas { get; set; }

        /// <summary>
        /// 取込管理
        /// </summary>
        public DbSet<TTorikomiManage> TTorikomiManages { get; set; }

        /// <summary>
        /// 取込対象マスタ
        /// </summary>
        public DbSet<MTorikomi> MTorikomis { get; set; }

        /// <summary>
        /// 操作履歴
        /// </summary>
        public DbSet<TSosaRireki> TSosaRirekis { get; set; }

        public DbSet<M00010共済目的名称> M00010共済目的名称s { get; set; }

        public DbSet<M00020類名称> M00020類名称s { get; set; }

        public DbSet<M00030区分名称> M00030区分名称s { get; set; }

        public DbSet<M00040田畑名称> M00040田畑名称s { get; set; }

        public DbSet<M00050端数処理名称> M00050端数処理名称s { get; set; }

        public DbSet<M00060全相殺計算方法名称> M00060全相殺計算方法名称s { get; set; }

        public DbSet<M00070収穫量確認方法名称> M00070収穫量確認方法名称s { get; set; }

        public DbSet<M00090営農継続単価> M00090営農継続単価s { get; set; }

        public DbSet<M00100修正限界> M00100修正限界s { get; set; }

        public DbSet<M00110品種係数> M00110品種係数s { get; set; }

        public DbSet<M00120料率> M00120料率s { get; set; }

        public DbSet<M00130産地別銘柄名称設定> M00130産地別銘柄名称設定s { get; set; }

        public DbSet<M00140名称> M00140名称s { get; set; }

        public DbSet<M00150帳票管理> M00150帳票管理s { get; set; }

        public DbSet<M00170統計単位地域> M00170統計単位地域s { get; set; }

        public DbSet<M00180担手農家区分名称> M00180担手農家区分名称s { get; set; }

        public DbSet<M00190大量データ対象データ> M00190大量データ対象データs { get; set; }

        public DbSet<T00010引受回> T00010引受回s { get; set; }

        public DbSet<T00020引受確定> T00020引受確定s { get; set; }

        public DbSet<T00030当初評価確定> T00030当初評価確定s { get; set; }

        public DbSet<T00040報告回> T00040報告回s { get; set; }

        public DbSet<T00050交付回> T00050交付回s { get; set; }

        public DbSet<T00060請求回> T00060請求回s { get; set; }

        public DbSet<T01010ポータル表示情報引受情報> T01010ポータル表示情報引受情報s { get; set; }

        public DbSet<T01020ポータル表示情報被害情報> T01020ポータル表示情報被害情報s { get; set; }

        public DbSet<T01050バッチ条件> T01050バッチ条件s { get; set; }

        public DbSet<T01060大量データ受入履歴> T01060大量データ受入履歴s { get; set; }

        public DbSet<T01070大量データ取込履歴> T01070大量データ取込履歴s { get; set; }

        public DbSet<T01080大量データ受入エラーリスト> T01080大量データ受入エラーリストs { get; set; }

        public DbSet<M10010組合等設定> M10010組合等設定s { get; set; }

        public DbSet<M10020分割単当減収量入力設定 > M10020分割単当減収量入力設定s { get; set; }

        public DbSet<M10030危険段階共済掛金区分> M10030危険段階共済掛金区分s { get; set; }

        public DbSet<M10040参酌係数> M10040参酌係数s { get; set; }

        public DbSet<M10050基準単収> M10050基準単収s { get; set; }

        public DbSet<M10060収量等級> M10060収量等級s { get; set; }

        public DbSet<M10070統計単収引受> M10070統計単収引受s { get; set; }

        public DbSet<M10080引受方式名称> M10080引受方式名称s { get; set; }

        public DbSet<M10090引受区分名称> M10090引受区分名称s { get; set; }

        public DbSet<M10100特約区分名称> M10100特約区分名称s { get; set; }

        public DbSet<M10110用途区分名称> M10110用途区分名称s { get; set; }

        public DbSet<M10120用途区分選択> M10120用途区分選択s { get; set; }

        public DbSet<M10130種類区分名称> M10130種類区分名称s { get; set; }

        public DbSet<M10140種類名称> M10140種類名称s { get; set; }

        public DbSet<M10150解除理由名称> M10150解除理由名称s { get; set; }

        public DbSet<M10160賦課金引受方式名称> M10160賦課金引受方式名称s { get; set; }

        public DbSet<M10170選択引受方式> M10170選択引受方式s { get; set; }

        public DbSet<M10180単位当たり共済金額設定> M10180単位当たり共済金額設定s { get; set; }

        public DbSet<M10190契約価格等設定> M10190契約価格等設定s { get; set; }

        public DbSet<M10195契約価格等設定規格別> M10195契約価格等設定規格別s { get; set; }

        public DbSet<M10200組合等単当共済金額> M10200組合等単当共済金額s { get; set; }

        public DbSet<M10210単当共済金額用途> M10210単当共済金額用途s { get; set; }

        public DbSet<M10220地区別設定> M10220地区別設定s { get; set; }

        public DbSet<M10230危険段階> M10230危険段階s { get; set; }

        public DbSet<M10240危険段階地域別設定> M10240危険段階地域別設定s { get; set; }

        public DbSet<M10250賦課金組合設定> M10250賦課金組合設定s { get; set; }

        public DbSet<M10260賦課金ランク共通> M10260賦課金ランク共通s { get; set; }

        public DbSet<M10270賦課金詳細> M10270賦課金詳細s { get; set; }

        public DbSet<M10280用途課税名称> M10280用途課税名称s { get; set; }

        public DbSet<T10010賦課金エラー情報> T10010賦課金エラー情報s { get; set; }

        public DbSet<M20010被害判定名称> M20010被害判定名称s { get; set; }

        public DbSet<M20020被害区分名称> M20020被害区分名称s { get; set; }

        public DbSet<M20030補償割合名称> M20030補償割合名称s { get; set; }

        public DbSet<M20040平均単収差計算名称> M20040平均単収差計算名称s { get; set; }

        public DbSet<M20050支払対象区分> M20050支払対象区分s { get; set; }

        public DbSet<M20060計算割合> M20060計算割合s { get; set; }

        public DbSet<M20070計算単位換算表> M20070計算単位換算表s { get; set; }

        public DbSet<M20080計算単位換算表類> M20080計算単位換算表類s { get; set; }

        public DbSet<M20090共済事故種類> M20090共済事故種類s { get; set; }

        public DbSet<M20100災害種類> M20100災害種類s { get; set; }

        public DbSet<M20110受託者等> M20110受託者等s { get; set; }

        public DbSet<M20120階層区分> M20120階層区分s { get; set; }

        public DbSet<M20130評価地区> M20130評価地区s { get; set; }

        public DbSet<M20140抜取調査班> M20140抜取調査班s { get; set; }

        public DbSet<M20150抜取班連携> M20150抜取班連携s { get; set; }

        public DbSet<M20160政府保険認定区分> M20160政府保険認定区分s { get; set; }

        public DbSet<M20170政府保険認定区分初期値> M20170政府保険認定区分初期値s { get; set; }

        public DbSet<M20180出荷評価地区名称> M20180出荷評価地区名称s { get; set; }

        public DbSet<M20190出荷階層区分名称> M20190出荷階層区分名称s { get; set; }

        public DbSet<M20200出荷評価地区コード設定> M20200出荷評価地区コード設定s { get; set; }

        public DbSet<M20210引受方式別判定> M20210引受方式別判定s { get; set; }

        public DbSet<M20220分割耕地判定名称> M20220分割耕地判定名称s { get; set; }

        public DbSet<M00200換算係数計算方法名称> M00200換算係数計算方法名称s { get; set; }

        public DbSet<M00210様式文言> M00210様式文言s { get; set; }

        public DbSet<M00220共済目的対応> M00220共済目的対応s { get; set; }

        public DbSet<M00230営農対象名称> M00230営農対象名称s { get; set; }

        public DbSet<M00240メニュー> M00240メニューs { get; set; }

        public DbSet<M20230一筆全半損判定名称> M20230一筆全半損判定名称s { get; set; }

        public DbSet<T50010農作物実績マスタ> T50010農作物実績マスタs { get; set; }

        public DbSet<T11010個人設定> T11010個人設定s { get; set; }

        public DbSet<T11020個人設定解除> T11020個人設定解除s { get; set; }

        public DbSet<T11030個人設定類> T11030個人設定類s { get; set; }

        public DbSet<T11040個人料率> T11040個人料率s { get; set; }

        public DbSet<T11050個人用途別> T11050個人用途別s { get; set; }

        public DbSet<T11060基準収穫量設定> T11060基準収穫量設定s { get; set; }

        public DbSet<T11070基準収穫量設定規格別> T11070基準収穫量設定規格別s { get; set; }

        public DbSet<T11090引受耕地> T11090引受耕地s { get; set; }

        public DbSet<T11100引受gis> T11100引受giss { get; set; }

        public DbSet<T12010引受結果> T12010引受結果s { get; set; }

        public DbSet<T12020引受チェック> T12020引受チェックs { get; set; }

        public DbSet<T12030用途チェック> T12030用途チェックs { get; set; }

        public DbSet<T12040組合員等別引受情報> T12040組合員等別引受情報s { get; set; }

        public DbSet<T12050組合員等別引受用途> T12050組合員等別引受用途s { get; set; }

        public DbSet<T12060産地別銘柄別引受情報> T12060産地別銘柄別引受情報s { get; set; }

        public DbSet<T12070産地別銘柄別引受情報規格別> T12070産地別銘柄別引受情報規格別s { get; set; }

        public DbSet<T12080組合員等別共済金額設定> T12080組合員等別共済金額設定s { get; set; }

        public DbSet<T12090組合員等別徴収情報> T12090組合員等別徴収情報s { get; set; }

        public DbSet<T12100基準単収修正量> T12100基準単収修正量s { get; set; }

        public DbSet<T12110基準収穫量集計表> T12110基準収穫量集計表s { get; set; }

        public DbSet<T12120組合員等別賦課金情報> T12120組合員等別賦課金情報s { get; set; }

        public DbSet<T12130最低付保割合> T12130最低付保割合s { get; set; }

        public DbSet<T12140引受耕地削除データ保持> T12140引受耕地削除データ保持s { get; set; }

        public DbSet<T13010組合等引受合計部> T13010組合等引受合計部s { get; set; }

        public DbSet<T13020組合等引受危険段階毎明細部> T13020組合等引受危険段階毎明細部s { get; set; }

        public DbSet<T13030組合等引受告示単価毎明細部> T13030組合等引受告示単価毎明細部s { get; set; }

        public DbSet<T13040組合等引受危険段階毎明細部Pq> T13040組合等引受危険段階毎明細部Pqs { get; set; }

        public DbSet<T13050支所別引受集計情報> T13050支所別引受集計情報s { get; set; }

        public DbSet<T13060引受通知書> T13060引受通知書s { get; set; }

        public DbSet<T14010規模別分布> T14010規模別分布s { get; set; }

        public DbSet<T14060面積区分情報> T14060面積区分情報s { get; set; }

        public DbSet<T14070規模別面積区分情報> T14070規模別面積区分情報s { get; set; }

        public DbSet<T15010交付徴収> T15010交付徴収s { get; set; }

        public DbSet<T15020組合等交付> T15020組合等交付s { get; set; }

        public DbSet<T19010大量データ受入異動申告ok> T19010大量データ受入異動申告oks { get; set; }

        public DbSet<T19020大量データ受入基準収穫量ok> T19020大量データ受入基準収穫量oks { get; set; }

        public DbSet<T19030大量データ受入組合員等別補償割合等ok> T19030大量データ受入組合員等別補償割合等oks { get; set; }

        public DbSet<T19040大量データ受入組合員等別類別一筆半損特約等o> T19040大量データ受入組合員等別類別一筆半損特約等os { get; set; }

        public DbSet<T19070大量データ受入加入申込書ok> T19070大量データ受入加入申込書oks { get; set; }

        public DbSet<T21010組合員等申告全相殺> T21010組合員等申告全相殺s { get; set; }

        public DbSet<T21020組合員等申告インデックス> T21020組合員等申告インデックスs { get; set; }

        public DbSet<T21030組合員等申告Pq> T21030組合員等申告Pqs { get; set; }

        public DbSet<T21040悉皆評価> T21040悉皆評価s { get; set; }

        public DbSet<T21050悉皆評価計算結果> T21050悉皆評価計算結果s { get; set; }

        public DbSet<T21060共済事故等情報入力> T21060共済事故等情報入力s { get; set; }

        public DbSet<T21070特例悉皆評価> T21070特例悉皆評価s { get; set; }

        public DbSet<T21080農単抜取調査> T21080農単抜取調査s { get; set; }

        public DbSet<T21090売渡全数調査> T21090売渡全数調査s { get; set; }

        public DbSet<T21100施設計量> T21100施設計量s { get; set; }

        public DbSet<T21110施設全数調査> T21110施設全数調査s { get; set; }

        public DbSet<T21120施設搬入収穫量> T21120施設搬入収穫量s { get; set; }

        public DbSet<T21130税務申告全数調査> T21130税務申告全数調査s { get; set; }

        public DbSet<T21140統計単収評価> T21140統計単収評価s { get; set; }

        public DbSet<T21150出荷収穫量評価> T21150出荷収穫量評価s { get; set; }

        public DbSet<T21160耕地面積分割評価情報> T21160耕地面積分割評価情報s { get; set; }

        public DbSet<T21170出荷数量等調査野帳情報> T21170出荷数量等調査野帳情報s { get; set; }

        public DbSet<T21180出荷数量等調査野帳情報規格別> T21180出荷数量等調査野帳情報規格別s { get; set; }

        public DbSet<T21190自家保有数量情報> T21190自家保有数量情報s { get; set; }

        public DbSet<T21200出荷評価地区別生産数量入力> T21200出荷評価地区別生産数量入力s { get; set; }

        public DbSet<T21210評価チェック> T21210評価チェックs { get; set; }

        public DbSet<T22010組合員等別仮渡情報> T22010組合員等別仮渡情報s { get; set; }

        public DbSet<T22015組合員等別仮渡情報類> T22015組合員等別仮渡情報類s { get; set; }

        public DbSet<T22020仮渡計算組合員等別> T22020仮渡計算組合員等別s { get; set; }

        public DbSet<T22030仮渡計算耕地別> T22030仮渡計算耕地別s { get; set; }

        public DbSet<T22040仮渡し設定> T22040仮渡し設定s { get; set; }

        public DbSet<T23010検見抜取評価> T23010検見抜取評価s { get; set; }

        public DbSet<T23020実測抜取評価> T23020実測抜取評価s { get; set; }

        public DbSet<T23030平均単収差選択抜取班> T23030平均単収差選択抜取班s { get; set; }

        public DbSet<T23040平均単収差選択調整班> T23040平均単収差選択調整班s { get; set; }

        public DbSet<T23050平均単収差> T23050平均単収差s { get; set; }

        public DbSet<T23060平均単収差抜取班集計> T23060平均単収差抜取班集計s { get; set; }

        public DbSet<T23070平均単収差検見単収> T23070平均単収差検見単収s { get; set; }

        public DbSet<T23080平均単収差実測単収> T23080平均単収差実測単収s { get; set; }

        public DbSet<T23090調整班平均単収差> T23090調整班平均単収差s { get; set; }

        public DbSet<T23100調整班平均単収差引受方式集計> T23100調整班平均単収差引受方式集計s { get; set; }

        public DbSet<T23110調整班平均単収差検見単収> T23110調整班平均単収差検見単収s { get; set; }

        public DbSet<T23120単当修正量> T23120単当修正量s { get; set; }

        public DbSet<T23130調後悉皆評価> T23130調後悉皆評価s { get; set; }

        public DbSet<T24010組合員等別損害情報> T24010組合員等別損害情報s { get; set; }

        public DbSet<T24020当初計算経過筆> T24020当初計算経過筆s { get; set; }

        public DbSet<T24030当初計算経過組合員等> T24030当初計算経過組合員等s { get; set; }

        public DbSet<T24040特例組合員等別損害情報> T24040特例組合員等別損害情報s { get; set; }

        public DbSet<T24050組合等当初評価> T24050組合等当初評価s { get; set; }

        public DbSet<T24060耕地別分割評価情報> T24060耕地別分割評価情報s { get; set; }

        public DbSet<T24070耕地別一筆全損半損評価情報　> T24070耕地別一筆全損半損評価情報s { get; set; }

        public DbSet<T24080規格別収穫量等配分計算> T24080規格別収穫量等配分計算s { get; set; }

        public DbSet<T24090規格別収穫量等配分計算規格別> T24090規格別収穫量等配分計算規格別s { get; set; }

        public DbSet<T24100産地別銘柄別評価情報> T24100産地別銘柄別評価情報s { get; set; }

        public DbSet<T24110産地別銘柄別評価情報規格別> T24110産地別銘柄別評価情報規格別s { get; set; }

        public DbSet<T24120組合員等類別評価情報> T24120組合員等類別評価情報s { get; set; }

        public DbSet<T24130組合員等別評価情報> T24130組合員等別評価情報s { get; set; }

        public DbSet<T24140地区別評価情報> T24140地区別評価情報s { get; set; }

        public DbSet<T24150組合等当初評価高情報> T24150組合等当初評価高情報s { get; set; }

        public DbSet<T24160組合等損害評価書情報> T24160組合等損害評価書情報s { get; set; }

        public DbSet<T24165損害評価書情報集計> T24165損害評価書情報集計s { get; set; }

        public DbSet<T24170政府再保険認定区分別当初評価高情報> T24170政府再保険認定区分別当初評価高情報s { get; set; }

        public DbSet<T24175当初評価高情報集計> T24175当初評価高情報集計s { get; set; }

        public DbSet<T24180政府再保険認定区分類区分別損害評価書情報> T24180政府再保険認定区分類区分別損害評価書情報s { get; set; }

        public DbSet<T24200産地別銘柄別評価情報営農> T24200産地別銘柄別評価情報営農s { get; set; }

        public DbSet<T24210産地別銘柄別評価情報営農規格別> T24210産地別銘柄別評価情報営農規格別s { get; set; }

        public DbSet<T24220組合員等類別評価情報営農> T24220組合員等類別評価情報営農s { get; set; }

        public DbSet<T24230産地別銘柄別評価情報一筆全半損営農> T24230産地別銘柄別評価情報一筆全半損営農s { get; set; }

        public DbSet<T24240産地別銘柄別評価情報一筆全半損営農規格別> T24240産地別銘柄別評価情報一筆全半損営農規格別s { get; set; }

        public DbSet<T24250調後組合員等別損害情報> T24250調後組合員等別損害情報s { get; set; }

        public DbSet<T24260調後組合等当初評価> T24260調後組合等当初評価s { get; set; }

        public DbSet<T24270支所別当初評価集計> T24270支所別当初評価集計s { get; set; }

        public DbSet<T24280調後支所別当初評価集計> T24280調後支所別当初評価集計s { get; set; }

        public DbSet<T24290支所別当初評価高情報> T24290支所別当初評価高情報s { get; set; }

        public DbSet<T25010組合員等別免責情報> T25010組合員等別免責情報s { get; set; }

        public DbSet<T25020組合員等別支払情報> T25020組合員等別支払情報s { get; set; }

        public DbSet<T25030組合員等別支払情報明細> T25030組合員等別支払情報明細s { get; set; }

        public DbSet<T26010保険金> T26010保険金s { get; set; }

        public DbSet<T26020保険金引受方式明細> T26020保険金引受方式明細s { get; set; }

        public DbSet<T29010大量データ受入分割情報ok> T29010大量データ受入分割情報oks { get; set; }

        public DbSet<T29020大量データ受入出荷数量等調査野帳ok> T29020大量データ受入出荷数量等調査野帳oks { get; set; }

        public DbSet<T29030大量データ受入自家保有数量ok> T29030大量データ受入自家保有数量oks { get; set; }

        public DbSet<T29040大量データ受入組合員等別類別連合会認定区分o> T29040大量データ受入組合員等別類別連合会認定区分os { get; set; }

        public DbSet<T29050大量データ受入一筆半損情報ok> T29050大量データ受入一筆半損情報oks { get; set; }

        public DbSet<T29060大量データ受入農単申告抜取調査ok> T29060大量データ受入農単申告抜取調査oks { get; set; }

        public DbSet<T29080大量データ受入全相殺損害評価野帳ok> T29080大量データ受入全相殺損害評価野帳oks { get; set; }

        public DbSet<T29090大量データ受入全相殺組合員等類別収穫量ok> T29090大量データ受入全相殺組合員等類別収穫量oks { get; set; }

        public DbSet<T29100大量データ受入全相殺施設搬入調査ok> T29100大量データ受入全相殺施設搬入調査oks { get; set; }

        public DbSet<T29110大量データ受入全相殺売渡数量調査ok> T29110大量データ受入全相殺売渡数量調査oks { get; set; }

        public DbSet<T29120大量データ受入全相殺税務申告調査ok> T29120大量データ受入全相殺税務申告調査oks { get; set; }

       
    }
}
