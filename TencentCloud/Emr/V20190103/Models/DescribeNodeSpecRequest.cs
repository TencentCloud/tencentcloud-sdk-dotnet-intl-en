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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNodeSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability zone (AZ) ID. https://document.capi.woa.com/document/api/1605/76892 can be accessed for related information.
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 0: pay-as-you-go; 1: yearly/monthly subscription; 99: a combination of pay-as-you-go and yearly/monthly subscription. Invalid values will suppress billing display.
        /// </summary>
        [JsonProperty("CvmPayMode")]
        public ulong? CvmPayMode{ get; set; }

        /// <summary>
        /// Node type: Master,Core,Task,Router,All.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 0: old billing page; 1: new billing page. Invalid values will be deemed to be old billing by default.
        /// </summary>
        [JsonProperty("TradeType")]
        public ulong? TradeType{ get; set; }

        /// <summary>
        /// Product ID. If left blank, the value is "0". This field is used to represent the product ID in all situations. It is required in front-end scenarios.
        /// 
        /// 44	EMR	V3.5.0
        /// 43	EMR	V3.4.0.tlinux
        /// 42	EMR	V2.7.0.tlinux
        /// 41	DRUID	V1.1.0
        /// 67	STARROCKS	V2.2.0
        /// 45	DRUID	V1.1.0.tlinux
        /// 40	EMRCLOUD	v3.2.0
        /// 47	EMR	V4.0.0
        /// 48	STARROCKS	V1.2.0
        /// 49	STARROCKS	V1.3.0
        /// 50	KAFKA	V2.0.0
        /// 51	STARROCKS	V1.4.0
        /// 52	EMR-TKE	V1.0.0
        /// 53	EMR	V3.6.0
        /// 54	STARROCKS	V2.0.0
        /// 55	EMR-TKE	V1.0.1
        /// 56	EMR-TKE	DLCV1.0.0
        /// 57	EMR	V2.8.0
        /// 58	EMR	V3.6.1
        /// 59	SERVERLESS	V1.0.0
        /// 60	EMR-TKE	V1.1.0
        /// 62	STARROCKS	V2.1.1
        /// 63	STARROCKS	V2.1.1.tlinux
        /// 64	EMR-TKE	TCCV1.0.0
        /// 65	EMR-TKE-AI	V1.0.0
        /// 66	RSS	V1.0.0
        /// 24	EMR	TianQiong-V1.0.0
        /// 3	EMR	V2.0.1.tlinux
        /// 4	EMR	V2.1.0
        /// 7	EMR	V3.0.0
        /// 8	EMR	V3.0.0.tlinux
        /// 9	EMR	V2.2.0
        /// 11	CLICKHOUSE	V1.0.0
        /// 12	CLICKHOUSE	V1.0.0.tlinux
        /// 16	EMR	V2.3.0
        /// 17	CLICKHOUSE	V1.1.0
        /// 18	CLICKHOUSE	V1.1.0.tlinux
        /// 19	EMR	V2.4.0
        /// 20	EMR	V2.5.0
        /// 21	USERCUSTOM	V1.0.0
        /// 22	CLICKHOUSE	V1.2.0
        /// 39	STARROCKS	V1.1.0
        /// 25	EMR	V3.1.0
        /// 26	DORIS	V1.0.0
        /// 27	KAFKA	V1.0.0
        /// 28	EMR	V3.2.0
        /// 29	EMR	V2.5.1
        /// 30	EMR	V2.6.0
        /// 32	DORIS	V1.1.0
        /// 33	EMR	V3.2.1
        /// 34	EMR	V3.3.0
        /// 35	DORIS	V1.2.0
        /// 36	STARROCKS	V1.0.0
        /// 37	EMR	V3.4.0
        /// 38	EMR	V2.7.0
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// Scenario name.
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// The type can be ComputeResource, EMR, or a default value. The default value is EMR.
        /// </summary>
        [JsonProperty("ResourceBaseType")]
        public string ResourceBaseType{ get; set; }

        /// <summary>
        /// Computing resource ID.
        /// </summary>
        [JsonProperty("ComputeResourceId")]
        public string ComputeResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "CvmPayMode", this.CvmPayMode);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "ResourceBaseType", this.ResourceBaseType);
            this.SetParamSimple(map, prefix + "ComputeResourceId", this.ComputeResourceId);
        }
    }
}

