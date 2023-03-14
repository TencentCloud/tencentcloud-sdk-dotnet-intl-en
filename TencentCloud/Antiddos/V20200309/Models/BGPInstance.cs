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
        /// Details of the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("InstanceDetail")]
        public InstanceRelation InstanceDetail{ get; set; }

        /// <summary>
        /// Specifications of the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("SpecificationLimit")]
        public BGPInstanceSpecification SpecificationLimit{ get; set; }

        /// <summary>
        /// Usage statistics of the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("Usage")]
        public BGPInstanceUsages Usage{ get; set; }

        /// <summary>
        /// Region of the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("Region")]
        public RegionInfo Region{ get; set; }

        /// <summary>
        /// Status of the Anti-DDoS Pro instance. Valid values:
        /// `idle`: The instance is running normally.
        /// `attacking`: The instance is under attack.
        /// `blocking`: The instance is blocked.
        /// `creating`: The instance is being created.
        /// `deblocking`: Unblocking the instance
        /// `isolate`: The instance is being isolated.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Purchase time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Name of the Anti-DDoS Pro instance
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Details of the package to which the Anti-DDoS Pro instance belongs.
        /// When the package provided is not used by the instance, this field is `null`.
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
        /// `idle`: The instance is bound.
        ///  `bounding`: Binding the instance.
        /// `failed`: Failed to bind
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
        /// Status of CC protection
        /// </summary>
        [JsonProperty("CCEnable")]
        public long? CCEnable{ get; set; }

        /// <summary>
        /// Tags associated with the resource
        /// </summary>
        [JsonProperty("TagInfoList")]
        public TagInfo[] TagInfoList{ get; set; }

        /// <summary>
        /// New edition of Anti-DDoS Pro
        /// </summary>
        [JsonProperty("IpCountNewFlag")]
        public ulong? IpCountNewFlag{ get; set; }

        /// <summary>
        /// The version of attack defense package
        /// </summary>
        [JsonProperty("VitalityVersion")]
        public ulong? VitalityVersion{ get; set; }

        /// <summary>
        /// Network line
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Line")]
        public ulong? Line{ get; set; }

        /// <summary>
        /// Whether to enable elastic bandwidth
        /// </summary>
        [JsonProperty("ElasticServiceBandwidth")]
        public ulong? ElasticServiceBandwidth{ get; set; }

        /// <summary>
        /// Bandwidth quota given away by Tencent Cloud
        /// </summary>
        [JsonProperty("GiftServiceBandWidth")]
        public long? GiftServiceBandWidth{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
            this.SetParamSimple(map, prefix + "IpCountNewFlag", this.IpCountNewFlag);
            this.SetParamSimple(map, prefix + "VitalityVersion", this.VitalityVersion);
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "ElasticServiceBandwidth", this.ElasticServiceBandwidth);
            this.SetParamSimple(map, prefix + "GiftServiceBandWidth", this.GiftServiceBandWidth);
        }
    }
}

