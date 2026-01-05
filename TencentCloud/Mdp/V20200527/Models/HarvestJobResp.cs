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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HarvestJobResp : AbstractModel
    {
        
        /// <summary>
        /// HarvestJob ID, a globally unique identifier.
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// The associated channel name.
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// The associated endpoint name.
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// Time format, supports the following types: 1. Epoch seconds 2. ISO-8601
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// HarvestJob start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// HarvestJob end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// The path where the recording file is stored in COS.
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// The file name of the recording file stored in COS.
        /// </summary>
        [JsonProperty("Manifest")]
        public string Manifest{ get; set; }

        /// <summary>
        /// The task status is divided into running: Running, execution completed: Completed, and execution failure: Failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// HarvestJob error message.
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// HarvestJob creation time, timestamp in seconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// The associated ChannelID.
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// The region corresponding to the harvest job.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Callback URL after recording is completed
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }


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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
        }
    }
}

