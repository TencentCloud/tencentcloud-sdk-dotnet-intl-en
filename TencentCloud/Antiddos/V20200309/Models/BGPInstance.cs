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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPInstance : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS instance details
        /// </summary>
        [JsonProperty("InstanceDetail")]
        public InstanceRelation InstanceDetail{ get; set; }

        /// <summary>
        /// Anti-DDoS instance specifications
        /// </summary>
        [JsonProperty("SpecificationLimit")]
        public BGPInstanceSpecification SpecificationLimit{ get; set; }

        /// <summary>
        /// Anti-DDoS instance usage statistics
        /// </summary>
        [JsonProperty("Usage")]
        public BGPInstanceUsages Usage{ get; set; }

        /// <summary>
        /// Region of the Anti-DDoS instance
        /// </summary>
        [JsonProperty("Region")]
        public RegionInfo Region{ get; set; }

        /// <summary>
        /// Status of the Anti-DDoS instance. Valid values:
        /// `idle`: running
        /// `attacking`: under attacks
        /// `blocking`: blocked
        /// `creating`: creating
        /// `deblocking`: unblocked
        /// `isolate`: isolated
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Purchase Time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Name of the Anti-DDoS instance
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Package details of the Anti-DDoS instance.
        /// Note: This field is `null` for an Anti-DDoS instance without using a package.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PackInfo")]
        public PackInfo PackInfo{ get; set; }

        /// <summary>
        /// Details of the cloud product used by the EIP bound to the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("EipProductInfos")]
        public EipProductInfo[] EipProductInfos{ get; set; }

        /// <summary>
        /// Binding status of the Anti-DDoS Pro instance
        /// `idle`: the instance is bound.
        ///  `bounding`: the instance is in binding.
        /// `failed`: the binding failed.
        /// ]
        /// </summary>
        [JsonProperty("BoundStatus")]
        public string BoundStatus{ get; set; }

        /// <summary>
        /// Layer-4 protection level
        /// </summary>
        [JsonProperty("DDoSLevel")]
        public string DDoSLevel{ get; set; }

        /// <summary>
        /// CC protection switch
        /// </summary>
        [JsonProperty("CCEnable")]
        public long? CCEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstanceDetail.", this.InstanceDetail);
            this.SetParamObj(map, prefix + "SpecificationLimit.", this.SpecificationLimit);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamObj(map, prefix + "Region.", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PackInfo.", this.PackInfo);
            this.SetParamArrayObj(map, prefix + "EipProductInfos.", this.EipProductInfos);
            this.SetParamSimple(map, prefix + "BoundStatus", this.BoundStatus);
            this.SetParamSimple(map, prefix + "DDoSLevel", this.DDoSLevel);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
        }
    }
}

