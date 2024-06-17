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

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Primary AZ of the instance in the format of `ap-guangzhou-3`. To support multiple AZs, add information of the primary and standby AZs in the `DBNodeSet.N` field.
        /// The information of AZ can be obtained from the `Zone` field in the return value of the [DescribeZones](https://intl.cloud.tencent.com/document/api/409/16769?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Purchasable code, which can be obtained from the `SpecCode` field in the return value of the [DescribeClasses](https://intl.cloud.tencent.com/document/api/409/89019?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// Instance storage capacity in GB
        /// </summary>
        [JsonProperty("Storage")]
        public ulong? Storage{ get; set; }

        /// <summary>
        /// The number of instances to be purchased at a time. Value range: 1-10. To purchase more than 10 instances each time, you can make multiple calls.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// Purchase duration, in months.
        /// <li>Prepaid: Supports `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `24`, and `36`.</li>
        /// <li>Pay-as-you-go: Only supports `1`.</li>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Instance character set, which currently supports only:
        /// <li>UTF8</li>
        /// <li>LATIN1</li>
        /// </summary>
        [JsonProperty("Charset")]
        public string Charset{ get; set; }

        /// <summary>
        /// Username of the instance root account, with the following specifications:
        /// <li>The username must consist of 1-16 characters, which can be letters, digits, or underscores.</li>
        /// <li>It cannot be postgres.</li>
        /// <li>It cannot start with digits or 'pg_'.</li>
        /// <li>All rules are case-insensitive.</li>
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// Password for the instance root account username, with a length of 8-32 characters. It is recommended to use a password of more than 12 characters and it cannot start with "/".
        /// It must include the following four types of characters:
        /// <li>Lowercase letters: [a ~ z]</li>
        /// <li>Uppercase letters: [A ~ Z]</li>
        /// <li>Digits: 0-9</li>
        /// <li>Special symbols: ()`~!@#$%^&*-+=_|{}[]:;'<>,.?/</li>
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// The major version number of PostgreSQL (this parameter is currently required), and the version information can be obtained from [DescribeDBVersions](https://intl.cloud.tencent.com/document/api/409/89018?from_cn_redirect=1). Currently major versions `10`, `11`, `12`, `13`, `14`, and `15` are supported. For details, see [Kernel Version Overview](https://intl.cloud.tencent.com/document/product/409/67018).
        /// When this parameter is entered, an instance running the latest kernel version of the latest minor version will be created based on this major version number.
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// PostgreSQL community major version + minor version number.
        /// It's generally not recommended to pass in this parameter. If needed, only the latest minor version number under the current major version can be passed.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// PostgreSQL kernel version number.
        /// It's generally not recommended to pass in this parameter. If needed, only the latest kernel version number under the current major version can be passed.
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// Instance billing type, which currently supports:
        /// <li>PREPAID: Prepaid, i.e., monthly subscription</li>
        /// <li>POSTPAID_BY_HOUR: Pay-as-you-go, i.e., pay by consumption</li>
        /// Default value: PREPAID
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// VPC ID, in the format of vpc-xxxxxxxx (this parameter is currently required). A valid VpcId can be obtained by logging into the console; it can also be obtained from the unVpcId field in the return value of calling of the [DescribeVpcEx](https://intl.cloud.tencent.com/document/api/215/1372?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID, in the format of subnet-xxxxxxxx (this parameter is currently required). A valid VPC subnet ID can be obtained by logging into the console; it can also be obtained from the unSubnetId field in the return value of calling of the [DescribeSubnets](https://intl.cloud.tencent.com/document/api/215/15784?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Deployment information of the instance node, which will display the information of each AZ when the instance node is deployed across multiple AZs.
        /// The information of AZ can be obtained from the `Zone` field in the return value of the [DescribeZones](https://intl.cloud.tencent.com/document/api/409/16769?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DBNodeSet")]
        public DBNode[] DBNodeSet{ get; set; }

        /// <summary>
        /// Renewal Flag:
        /// <li>`0`: manual renewal</li>
        /// <li>`1`: auto-renewal</li>
        /// Default value: 0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Whether to automatically use coupons:
        /// <li>`0`: no</li>
        /// <li>`1`: yes</li>
        /// Default value: 0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// Voucher ID list. Currently, you can specify only one voucher.
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Campaign ID
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// Instance name, which can contain up to 60 letters, digits, hyphens, and symbols (_-). If this parameter is not specified, "Unnamed" will be displayed by default.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The information of tags to be bound with the instance, which is left empty by default. This parameter can be obtained from the `Tags` field in the return value of the [DescribeTags](https://intl.cloud.tencent.com/document/api/651/35316?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Security group of the instance, which can be obtained from the `sgld` field in the return value of the [DescribeSecurityGroups](https://intl.cloud.tencent.com/document/api/215/15808?from_cn_redirect=1) API. If this parameter is not specified, the default security group will be bound.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Whether data transparent encryption is required:
        /// <li>`0`: no</li>
        /// <li>`1`: yes</li>
        /// Default value: 0See [Overview of Data Transparent Encryption](https://intl.cloud.tencent.com/document/product/409/71748?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NeedSupportTDE")]
        public ulong? NeedSupportTDE{ get; set; }

        /// <summary>
        /// KeyId of custom key, which is required if you select custom key encryption. It is also the unique CMK identifier.
        /// For more information on creating `KeyId`, see [Enabling TDE](https://www.tencentcloud.com/document/product/409/47762).
        /// </summary>
        [JsonProperty("KMSKeyId")]
        public string KMSKeyId{ get; set; }

        /// <summary>
        /// The region where the KMS service is enabled. When `KMSRegion` is left empty, the current region will be selected by default.  If the current region does not support KMS, you must select another region that does.
        /// For more information on `KMSRegion`, see [Enabling TDE](https://intl.cloud.tencent.com/document/product/409/71749?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("KMSRegion")]
        public string KMSRegion{ get; set; }

        /// <summary>
        /// Database engine, which supports:
        /// <li>`postgresql`: TencentDB for PostgreSQL</li>
        /// <li>`mssql_compatible`: MSSQL compatible - TencentDB for PostgreSQL</li>
        /// Default value: `postgresql`
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
        /// </summary>
        [JsonProperty("DBEngineConfig")]
        public string DBEngineConfig{ get; set; }

        /// <summary>
        /// Primary-standby sync mode, which supports:
        /// <li>Semi-sync: Semi-sync</li>
        /// <li>Async: Asynchronous</li>
        /// Default value for the primary instance: Semi-sync
        /// Default value for the read-only instance: Async
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// Whether support to IPv6 is required:
        /// <li>`0`: no</li>
        /// <li>`1`: yes</li>
        /// Default value: 0
        /// </summary>
        [JsonProperty("NeedSupportIpv6")]
        public ulong? NeedSupportIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "DBNodeSet.", this.DBNodeSet);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "NeedSupportTDE", this.NeedSupportTDE);
            this.SetParamSimple(map, prefix + "KMSKeyId", this.KMSKeyId);
            this.SetParamSimple(map, prefix + "KMSRegion", this.KMSRegion);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBEngineConfig", this.DBEngineConfig);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "NeedSupportIpv6", this.NeedSupportIpv6);
        }
    }
}

