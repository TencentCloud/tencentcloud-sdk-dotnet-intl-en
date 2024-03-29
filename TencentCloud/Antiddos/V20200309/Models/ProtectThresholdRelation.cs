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

    public class ProtectThresholdRelation : AbstractModel
    {
        
        /// <summary>
        /// DDoS protection level:
        /// `low`: loose protection
        /// `middle`: medium protection
        /// `high`: strict protection
        /// ]
        /// </summary>
        [JsonProperty("DDoSLevel")]
        public string DDoSLevel{ get; set; }

        /// <summary>
        /// DDoS cleansing threshold (in Mbps)
        /// </summary>
        [JsonProperty("DDoSThreshold")]
        public ulong? DDoSThreshold{ get; set; }

        /// <summary>
        /// DDoS AI protection switch:
        /// `on`: enabled
        /// `off`: disabled
        /// ]
        /// </summary>
        [JsonProperty("DDoSAI")]
        public string DDoSAI{ get; set; }

        /// <summary>
        /// CC cleansing switch
        /// `0`: disabled
        /// `1`: enabled
        /// ]
        /// </summary>
        [JsonProperty("CCEnable")]
        public ulong? CCEnable{ get; set; }

        /// <summary>
        /// CC cleansing threshold (in QPS)
        /// </summary>
        [JsonProperty("CCThreshold")]
        public ulong? CCThreshold{ get; set; }

        /// <summary>
        /// Anti-DDoS instance configured
        /// </summary>
        [JsonProperty("InstanceDetailList")]
        public InstanceRelation[] InstanceDetailList{ get; set; }

        /// <summary>
        /// Domain name and protocol protection thresholds
        /// </summary>
        [JsonProperty("ListenerCcThresholdList")]
        public ListenerCcThreholdConfig[] ListenerCcThresholdList{ get; set; }

        /// <summary>
        /// SYN traffic threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SynFloodThreshold")]
        public ulong? SynFloodThreshold{ get; set; }

        /// <summary>
        /// SYN packet threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SynFloodPktThreshold")]
        public ulong? SynFloodPktThreshold{ get; set; }

        /// <summary>
        /// UDP traffic threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UdpFloodThreshold")]
        public ulong? UdpFloodThreshold{ get; set; }

        /// <summary>
        /// UDP packet threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UdpFloodPktThreshold")]
        public ulong? UdpFloodPktThreshold{ get; set; }

        /// <summary>
        /// ACK traffic threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AckFloodThreshold")]
        public ulong? AckFloodThreshold{ get; set; }

        /// <summary>
        /// ACK packet threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AckFloodPktThreshold")]
        public ulong? AckFloodPktThreshold{ get; set; }

        /// <summary>
        /// SYNACK traffic threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SynAckFloodThreshold")]
        public ulong? SynAckFloodThreshold{ get; set; }

        /// <summary>
        /// SYNACK packet threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SynAckFloodPktThreshold")]
        public ulong? SynAckFloodPktThreshold{ get; set; }

        /// <summary>
        /// RST traffic threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RstFloodThreshold")]
        public ulong? RstFloodThreshold{ get; set; }

        /// <summary>
        /// RST packet threshold
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RstFloodPktThreshold")]
        public ulong? RstFloodPktThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DDoSLevel", this.DDoSLevel);
            this.SetParamSimple(map, prefix + "DDoSThreshold", this.DDoSThreshold);
            this.SetParamSimple(map, prefix + "DDoSAI", this.DDoSAI);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
            this.SetParamSimple(map, prefix + "CCThreshold", this.CCThreshold);
            this.SetParamArrayObj(map, prefix + "InstanceDetailList.", this.InstanceDetailList);
            this.SetParamArrayObj(map, prefix + "ListenerCcThresholdList.", this.ListenerCcThresholdList);
            this.SetParamSimple(map, prefix + "SynFloodThreshold", this.SynFloodThreshold);
            this.SetParamSimple(map, prefix + "SynFloodPktThreshold", this.SynFloodPktThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodThreshold", this.UdpFloodThreshold);
            this.SetParamSimple(map, prefix + "UdpFloodPktThreshold", this.UdpFloodPktThreshold);
            this.SetParamSimple(map, prefix + "AckFloodThreshold", this.AckFloodThreshold);
            this.SetParamSimple(map, prefix + "AckFloodPktThreshold", this.AckFloodPktThreshold);
            this.SetParamSimple(map, prefix + "SynAckFloodThreshold", this.SynAckFloodThreshold);
            this.SetParamSimple(map, prefix + "SynAckFloodPktThreshold", this.SynAckFloodPktThreshold);
            this.SetParamSimple(map, prefix + "RstFloodThreshold", this.RstFloodThreshold);
            this.SetParamSimple(map, prefix + "RstFloodPktThreshold", this.RstFloodPktThreshold);
        }
    }
}

