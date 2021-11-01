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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmTarget : AbstractModel
    {
        
        /// <summary>
        /// Log topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Query statement
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Monitoring object number, which is incremental from 1.
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// Offset of the query start time from the current time in minutes. The value cannot be positive. Value range: -1440–0.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public long? StartTimeOffset{ get; set; }

        /// <summary>
        /// Offset of the query end time from the current time in minutes. The value cannot be positive and must be greater than `StartTimeOffset`. Value range: -1440–0.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public long? EndTimeOffset{ get; set; }

        /// <summary>
        /// Logset ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
        }
    }
}

