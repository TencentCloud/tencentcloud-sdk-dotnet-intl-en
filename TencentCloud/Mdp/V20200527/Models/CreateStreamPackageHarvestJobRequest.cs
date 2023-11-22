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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStreamPackageHarvestJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Task ID, a globally unique identifier, ID can contain up to 128 characters. Supported characters are numbers, letters, underscores (_), and dashes (-).
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// The associated channel name.
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// The associated endpoint name, StreamPackage only supports harvesting content from HLS and DASH endpoints that have startover turned on.
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// Time format, supports the following types: 
        /// 1. Epoch seconds 
        /// 2. ISO-8601.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// Task start time supports two formats for TimeFormat input: 
        /// 1. Epoch seconds: The input box is a numeric input box, and only positive integers can be entered. 
        /// 2. ISO-8601: The supported format is ISO time, for example: 2023-08-01T10:00:00+08:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time supports two formats for TimeFormat input: 
        /// 1. Epoch seconds: The input box is a numeric input box, and only positive integers can be entered. 
        /// 2. ISO-8601: The supported format is ISO time, for example: 2023-08-01T10:00:00+08:00.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The COS bucket address where the recording file is stored in COS, format: https://{Bucket_name}-{AppId}.cos.{Region}.myqcloud.com/.
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// The path in the cos bucket and identifier for the parent manifest for the live-to-VOD asset, fotmat: {path 1}/xxx/{path n}/{name}.m3u8.
        /// </summary>
        [JsonProperty("Manifest")]
        public string Manifest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Destination", this.Destination);
            this.SetParamSimple(map, prefix + "Manifest", this.Manifest);
        }
    }
}

