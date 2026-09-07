/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBgpInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Payment type: payment mode: PREPAID (prepayment) POSTPAID_BY_MONTH (pay-as-you-go).
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// High-Protection package type: specifies the high-protection package type. valid values: Enterprise (Enterprise edition), Standard (Standard version), StandardPlus (Standard version 2.0).
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Specifies the number of anti-ddos packages to purchase. valid values: one-time purchase of no more than 10.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// { "Period": 3, "RenewFlag": "NOTIFY_AND_AUTO_RENEW" }
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// { "Region": "ap-guangzhou", "ProtectIpCount": 1, "BasicProtectBandwidth": 300, "Bandwidth": 100, "ElasticProtectLimit": 0, "ElasticBandwidthFlag": true }
        /// </summary>
        [JsonProperty("EnterprisePackageConfig")]
        public EnterprisePackageConfig EnterprisePackageConfig{ get; set; }

        /// <summary>
        /// { "Region": "ap-guangzhou", "ProtectIpCount": 1, "BasicProtectBandwidth": 300, "Bandwidth": 100, "ElasticProtectLimit": 0, "ElasticBandwidthFlag": true }
        /// </summary>
        [JsonProperty("StandardPackageConfig")]
        public StandardPackageConfig StandardPackageConfig{ get; set; }

        /// <summary>
        /// { "Region": "ap-guangzhou", "ProtectCount": "TWO_TIMES", "ProtectIpCount": 1, "Bandwidth": 100, "ElasticBandwidthFlag": true }
        /// </summary>
        [JsonProperty("StandardPlusPackageConfig")]
        public StandardPlusPackageConfig StandardPlusPackageConfig{ get; set; }

        /// <summary>
        /// [ { "TagKey": "beal-test",                 "TagValue": "beal-test"               }             ]
        /// </summary>
        [JsonProperty("TagInfoList")]
        public TagInfo[] TagInfoList{ get; set; }

        /// <summary>
        /// false by default. true indicates to perform parameter validation only without actual purchase.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "EnterprisePackageConfig.", this.EnterprisePackageConfig);
            this.SetParamObj(map, prefix + "StandardPackageConfig.", this.StandardPackageConfig);
            this.SetParamObj(map, prefix + "StandardPlusPackageConfig.", this.StandardPlusPackageConfig);
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

