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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time. The query time range (EndTime - StartTime) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Zone ID set. This parameter is required. A maximum of 100 zone IDs can be passed in. If you need to query data for all zones under the Tencent Cloud main account, please use "*" instead. To query account-level data, you need to have full resource permissions for all zones of this interface.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Metric name. Valid values:
        /// **Layer 4/7 Acceleration Traffic (Unit: Byte):**
        /// <li>acc_flux: content acceleration traffic, in bytes;</li>
        /// <li>smt_flux: smart acceleration traffic, in bytes;</li>
        /// <li>l4_flux: layer 4 acceleration traffic, in bytes;</li>
        /// <li>sec_flux: exclusive protection traffic, in bytes;</li>
        /// <li>zxctg_flux: network optimization traffic in the chinese mainland, in bytes;</li>
        /// 
        /// **Layer 4/7 Acceleration Bandwidth (Unit: bps):**
        /// <Li>acc_bandwidth: content acceleration bandwidth, in bps.</li>
        /// <li>smt_bandwidth: smart acceleration bandwidth, in bps;</li>
        /// <Li>l4_bandwidth: layer 4 acceleration bandwidth, in bps.</li>
        /// <li>sec_bandwidth: exclusive protection bandwidth, in bps.</li>
        /// <li>zxctg_bandwidth: network optimization bandwidth in the chinese mainland, in bps;</li>
        /// 
        /// **HTTP/HTTPS Security Requests (Unit: counts):**
        /// <li>sec_request_clean: number of HTTP/HTTPS requests;</li>
        /// 
        /// **Value-added Service Usage:**
        /// <li>smt_request_clean: number of smart acceleration requests, in counts;</li>
        /// <li>quic_request: number of quic requests;</li>
        /// <Li>bot_request_clean: number of bot requests;</li>
        /// <li>cls_count: number of real-time log entries pushed;</li>
        /// <li>ddos_bandwidth: elastic ddos protection bandwidth, in bps.</li>
        /// 
        /// **Edge Computing Usage:**
        /// <li>edgefunction_request: number of edge function executions, in counts</li>
        /// <li>edgefunction_cpu_time: edge function CPU processing time, in milliseconds</li>
        /// 
        /// **Media Processing Usage (Unit: seconds):**
        /// <li>total_transcode: duration of jit transcoding and transmuxing for all specifications of audio and video, in seconds;</li>
        /// <li>remux: transmuxing duration, in seconds;</li>
        /// <li>transcode_audio: audio transcoding duration, in seconds;</li>
        /// <li>transcode_H264_SD: specifies the duration of standard-definition videos encoded in H.264 (short side <= 480 px), in seconds;</li>
        /// <li>transcode_H264_HD: specifies the duration of high-definition video (short side <= 720 px) encoded in H.264, in seconds;</li>
        /// <li>transcode_H264_FHD: specifies the duration of a full hd video (short side <= 1080 px) encoded in H.264, in seconds;</li>
        /// <li>transcode_H264_2K: specifies the duration of a 2K video (short side <= 1440 px) encoded in H.264, expressed in seconds.</li>
        /// 
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Time granularity of the query. Valid values:
        /// <li>5min: 5 minutes;</li>
        /// <li>hour: 1 hour;</li>
        /// <li>day: 1 day.</li>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed values of filter criteria are as follows:
        /// <ul>
        ///   <li>host: Filter by domain name, such as test.example.com.</li>
        ///   <li>proxy-id: Filter by L4 proxy instance ID, such as sid-2rugn89bkla9.</li>
        ///   <li>region-id: Filter by billing region. Options:
        ///     <ul>
        ///       <li>CH: Chinese mainland</li>
        ///       <li>AF: Africa</li>
        ///       <li>AS1: Asia-Pacific Region 1</li>
        ///       <li>AS2: Asia-Pacific Region 2</li>
        ///       <li>AS3: Asia-Pacific Region 3</li>
        ///       <li>EU: Europe</li>
        ///       <li>MidEast: Middle East</li>
        ///       <li>NA: North America</li>
        ///       <li>SA: South America</li>
        ///     </ul>
        ///   </li>
        /// </ul>
        /// <p>Note: Filters of the same `Type` use OR logic, while filters of different `Type` use AND logic.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public BillingDataFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>Grouping aggregation dimensions. A maximum of two dimensions can be used for grouping simultaneously. The values are as follows:</p>
        ///   <ul>
        ///     <li>zone-id: Group by zone ID. If content identifiers are used, grouping by content identifier takes priority.</li>
        ///     <li>host: Group by domain name.</li>
        ///     <li>proxy-id: Group by layer-4 proxy instance ID.</li>
        ///     <li>region-id: Group by billing region.</li>
        ///   </ul>
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
        }
    }
}

