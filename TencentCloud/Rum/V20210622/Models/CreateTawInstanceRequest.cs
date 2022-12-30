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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTawInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Region ID (at least greater than 0)
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// Billing type (1: Pay-as-you-go).
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Data retention period (at least greater than 0)
        /// </summary>
        [JsonProperty("DataRetentionDays")]
        public long? DataRetentionDays{ get; set; }

        /// <summary>
        /// Instance name (up to 255 bytes)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Instance description (up to 1,024 bytes)
        /// </summary>
        [JsonProperty("InstanceDesc")]
        public string InstanceDesc{ get; set; }

        /// <summary>
        /// Number of data entries reported per day
        /// </summary>
        [JsonProperty("CountNum")]
        public string CountNum{ get; set; }

        /// <summary>
        /// Billing for data storage
        /// </summary>
        [JsonProperty("PeriodRetain")]
        public string PeriodRetain{ get; set; }

        /// <summary>
        /// Instance purchase channel. Valid value: `cdn`.
        /// </summary>
        [JsonProperty("BuyingChannel")]
        public string BuyingChannel{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResourcePackageType")]
        public ulong? ResourcePackageType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResourcePackageNum")]
        public ulong? ResourcePackageNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "DataRetentionDays", this.DataRetentionDays);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceDesc", this.InstanceDesc);
            this.SetParamSimple(map, prefix + "CountNum", this.CountNum);
            this.SetParamSimple(map, prefix + "PeriodRetain", this.PeriodRetain);
            this.SetParamSimple(map, prefix + "BuyingChannel", this.BuyingChannel);
            this.SetParamSimple(map, prefix + "ResourcePackageType", this.ResourcePackageType);
            this.SetParamSimple(map, prefix + "ResourcePackageNum", this.ResourcePackageNum);
        }
    }
}

