/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBInstance : AbstractModel
    {
        
        /// <summary>
        /// Instance region such as ap-guangzhou, which corresponds to the`Region` field in `RegionSet`.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance AZ such as ap-guangzhou-3, which corresponds to the `Zone` field of `ZoneSet`.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// VPC ID in the format of `vpc-xxxxxxx`, which can be obtained in the console or from the `unVpcId` field in the return value of the [DescribeVpcs](https://www.tencentcloud.com/document/product/215/15778) API.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID in the format of `subnet-xxxxxxxx`, which can be obtained in the console or from the `unSubnetId` field in the return value of the [DescribeSubnets ](https://intl.cloud.tencent.com/document/api/215/15784?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("DBInstanceName")]
        public string DBInstanceName{ get; set; }

        /// <summary>
        /// Instance status, including: `applying` (applying), `init` (to be initialized), `initing` (initializing), `running` (running), `limited run` (restricted operation), `isolating` (isolating), `isolated` (isolated), `disisolating` (de-isolating), `recycling` (recycling), `recycled` (recycled), `job running` (task executing), `offline` (offline), `migrating` (migrating), `expanding` (scaling out), `waitSwitch` (waiting to switch), `switching` (switching), `readonly` (readonly), `restarting` (restarting), `network changing` (network modification in progress), `upgrading` (kernel version upgrading), `audit-switching` (audit status changing), and `primary-switching` (primary-secondary switching)
        /// </summary>
        [JsonProperty("DBInstanceStatus")]
        public string DBInstanceStatus{ get; set; }

        /// <summary>
        /// Assigned instance memory size in GB
        /// </summary>
        [JsonProperty("DBInstanceMemory")]
        public ulong? DBInstanceMemory{ get; set; }

        /// <summary>
        /// Assigned instance storage capacity in GB
        /// </summary>
        [JsonProperty("DBInstanceStorage")]
        public ulong? DBInstanceStorage{ get; set; }

        /// <summary>
        /// Number of assigned CPUs
        /// </summary>
        [JsonProperty("DBInstanceCpu")]
        public ulong? DBInstanceCpu{ get; set; }

        /// <summary>
        /// Purchasable specification ID
        /// </summary>
        [JsonProperty("DBInstanceClass")]
        public string DBInstanceClass{ get; set; }

        /// <summary>
        /// The major PostgreSQL version number, which can be queried by the [DescribeDBVersions](https://intl.cloud.tencent.com/document/api/409/89018?from_cn_redirect=1) API. Valid values: `10`, `11`, `12`, `13`, `14`, `15`.
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// Number of the major PostgreSQL community version and minor version, such as 12.4, which can be queried by the [DescribeDBVersions](https://intl.cloud.tencent.com/document/api/409/89018?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// PostgreSQL kernel version number (like v12.7_r1.8), which can be queried by the [DescribeDBVersions](https://intl.cloud.tencent.com/document/api/409/89018?from_cn_redirect=1) API.
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// Instance type, which includes:
        /// <li>primary: primary instance </li>
        /// <li>readonly: read-only instance</li>
        /// <li>guard: disaster recovery instance</li>
        /// <li>temp: temporary instance</li>
        /// </summary>
        [JsonProperty("DBInstanceType")]
        public string DBInstanceType{ get; set; }

        /// <summary>
        /// Instance version. Valid value: `standard` (dual-server high-availability; one-primary-one-standby).
        /// </summary>
        [JsonProperty("DBInstanceVersion")]
        public string DBInstanceVersion{ get; set; }

        /// <summary>
        /// Instance character set, which currently supports only:
        /// <li>UTF8</li>
        /// <li>LATIN1</li>
        /// </summary>
        [JsonProperty("DBCharset")]
        public string DBCharset{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last updated time of the instance attribute
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Instance expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Instance isolation time
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// Billing mode:
        /// <li>prepaid: monthly subscription, prepaid</li>
        /// <li>postpaid: pay-as-you-go, postpaid</li>
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Auto-renewal or not:
        /// <li>`0`: manual renewal</li>
        /// <li>`1`: auto-renewal</li>
        /// Default value: 0
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Instance network connection information
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public DBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// Machine type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// User `AppId`
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Instance `Uid`
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// The information of tags associated with instances
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Primary instance information, which is returned only when the instance is read-only.
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// Number of read-only instances
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReadOnlyInstanceNum")]
        public long? ReadOnlyInstanceNum{ get; set; }

        /// <summary>
        /// The status of a read-only instance in a read-only group
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusInReadonlyGroup")]
        public string StatusInReadonlyGroup{ get; set; }

        /// <summary>
        /// Offline time
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// Instance node information
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBNodeSet")]
        public DBNode[] DBNodeSet{ get; set; }

        /// <summary>
        /// Whether the instance supports TDE data encryption:
        /// <li>0: not supported</li>
        /// <li>1: supported</li>
        /// Default value: 0For TDE data encryption, see [Overview of Data Transparent Encryption](https://intl.cloud.tencent.com/document/product/409/71748?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSupportTDE")]
        public long? IsSupportTDE{ get; set; }

        /// <summary>
        /// Database engine, which supports:
        /// <li>`postgresql`: TencentDB for PostgreSQL</li>
        /// <li>`mssql_compatible`: MSSQL compatible - TencentDB for PostgreSQL</li>
        /// Default value: `postgresql`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// Configuration information for the database engine, and the configuration format is as follows:
        /// {"$key1":"$value1", "$key2":"$value2"}
        /// Supported engines include:
        /// mssql_compatible engine:
        /// <li>migrationMode: Database mode, an optional parameter, and its valid values are: single-db (single database schema) and multi-db (multiple database schema). The default value is single-db.</li>
        /// <li>defaultLocale: Sorting area rule, an optional parameter, which cannot be modified after initialization, its default value is en_US, and its valid values include:
        /// "af_ZA", "sq_AL", "ar_DZ", "ar_BH", "ar_EG", "ar_IQ", "ar_JO", "ar_KW", "ar_LB", "ar_LY", "ar_MA", "ar_OM", "ar_QA", "ar_SA", "ar_SY", "ar_TN", "ar_AE", "ar_YE", "hy_AM", "az_Cyrl_AZ", "az_Latn_AZ", "eu_ES", "be_BY", "bg_BG", "ca_ES", "zh_HK", "zh_MO", "zh_CN", "zh_SG", "zh_TW", "hr_HR", "cs_CZ", "da_DK", "nl_BE", "nl_NL", "en_AU", "en_BZ", "en_CA", "en_IE", "en_JM", "en_NZ", "en_PH", "en_ZA", "en_TT", "en_GB", "en_US", "en_ZW", "et_EE", "fo_FO", "fa_IR", "fi_FI", "fr_BE", "fr_CA", "fr_FR", "fr_LU", "fr_MC", "fr_CH", "mk_MK", "ka_GE", "de_AT", "de_DE", "de_LI", "de_LU", "de_CH", "el_GR", "gu_IN", "he_IL", "hi_IN", "hu_HU", "is_IS", "id_ID", "it_IT", "it_CH", "ja_JP", "kn_IN", "kok_IN", "ko_KR", "ky_KG", "lv_LV", "lt_LT", "ms_BN", "ms_MY", "mr_IN", "mn_MN", "nb_NO", "nn_NO", "pl_PL", "pt_BR", "pt_PT", "pa_IN", "ro_RO", "ru_RU", "sa_IN", "sr_Cyrl_RS", "sr_Latn_RS", "sk_SK", "sl_SI", "es_AR", "es_BO", "es_CL", "es_CO", "es_CR", "es_DO", "es_EC", "es_SV", "es_GT", "es_HN", "es_MX", "es_NI", "es_PA", "es_PY","es_PE", "es_PR", "es_ES", "es_TRADITIONAL", "es_UY", "es_VE", "sw_KE", "sv_FI", "sv_SE", "tt_RU", "te_IN", "th_TH", "tr_TR", "uk_UA", "ur_IN", "ur_PK", "uz_Cyrl_UZ", "uz_Latn_UZ", and "vi_VN".</li>
        /// <li>serverCollationName: Sorting rule name, an optional parameter, which cannot be modified after initialization, its default value is sql_latin1_general_cp1_ci_as, and its valid values include: "bbf_unicode_general_ci_as", "bbf_unicode_cp1_ci_as", "bbf_unicode_CP1250_ci_as", "bbf_unicode_CP1251_ci_as", "bbf_unicode_cp1253_ci_as", "bbf_unicode_cp1254_ci_as", "bbf_unicode_cp1255_ci_as", "bbf_unicode_cp1256_ci_as", "bbf_unicode_cp1257_ci_as", "bbf_unicode_cp1258_ci_as", "bbf_unicode_cp874_ci_as", "sql_latin1_general_cp1250_ci_as", "sql_latin1_general_cp1251_ci_as", "sql_latin1_general_cp1_ci_as", "sql_latin1_general_cp1253_ci_as", "sql_latin1_general_cp1254_ci_as", "sql_latin1_general_cp1255_ci_as", "sql_latin1_general_cp1256_ci_as", "sql_latin1_general_cp1257_ci_as", "sql_latin1_general_cp1258_ci_as", "chinese_prc_ci_as", "cyrillic_general_ci_as", "finnish_swedish_ci_as", "french_ci_as", "japanese_ci_as", "korean_wansung_ci_as", "latin1_general_ci_as", "modern_spanish_ci_as", "polish_ci_as", "thai_ci_as", "traditional_spanish_ci_as", "turkish_ci_as", "ukrainian_ci_as", and "vietnamese_ci_as".</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBEngineConfig")]
        public string DBEngineConfig{ get; set; }

        /// <summary>
        /// Network access list of the instance (this field has been deprecated)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkAccessList")]
        public NetworkAccess[] NetworkAccessList{ get; set; }

        /// <summary>
        /// Whether the instance supports IPv6:
        /// <li>`0`: no</li>
        /// <li>`1`: yes</li>
        /// Default value: 0
        /// </summary>
        [JsonProperty("SupportIpv6")]
        public ulong? SupportIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "DBInstanceName", this.DBInstanceName);
            this.SetParamSimple(map, prefix + "DBInstanceStatus", this.DBInstanceStatus);
            this.SetParamSimple(map, prefix + "DBInstanceMemory", this.DBInstanceMemory);
            this.SetParamSimple(map, prefix + "DBInstanceStorage", this.DBInstanceStorage);
            this.SetParamSimple(map, prefix + "DBInstanceCpu", this.DBInstanceCpu);
            this.SetParamSimple(map, prefix + "DBInstanceClass", this.DBInstanceClass);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "DBInstanceType", this.DBInstanceType);
            this.SetParamSimple(map, prefix + "DBInstanceVersion", this.DBInstanceVersion);
            this.SetParamSimple(map, prefix + "DBCharset", this.DBCharset);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyInstanceNum", this.ReadOnlyInstanceNum);
            this.SetParamSimple(map, prefix + "StatusInReadonlyGroup", this.StatusInReadonlyGroup);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamArrayObj(map, prefix + "DBNodeSet.", this.DBNodeSet);
            this.SetParamSimple(map, prefix + "IsSupportTDE", this.IsSupportTDE);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBEngineConfig", this.DBEngineConfig);
            this.SetParamArrayObj(map, prefix + "NetworkAccessList.", this.NetworkAccessList);
            this.SetParamSimple(map, prefix + "SupportIpv6", this.SupportIpv6);
        }
    }
}

