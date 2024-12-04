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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySyncRateLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// Migration task ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Number of full export threads for sync task. Value range: 1-16.
        /// </summary>
        [JsonProperty("DumpThread")]
        public long? DumpThread{ get; set; }

        /// <summary>
        /// The full export Rps for sync task. The value needs to be greater than 0.
        /// </summary>
        [JsonProperty("DumpRps")]
        public long? DumpRps{ get; set; }

        /// <summary>
        /// Number of full import threads for sync task. Value range: 1-16.
        /// </summary>
        [JsonProperty("LoadThread")]
        public long? LoadThread{ get; set; }

        /// <summary>
        /// Number of incremental import threads for sync task. Value range: 1-128.
        /// </summary>
        [JsonProperty("SinkerThread")]
        public long? SinkerThread{ get; set; }

        /// <summary>
        /// The full import Rps for sync task.
        /// </summary>
        [JsonProperty("LoadRps")]
        public long? LoadRps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "DumpThread", this.DumpThread);
            this.SetParamSimple(map, prefix + "DumpRps", this.DumpRps);
            this.SetParamSimple(map, prefix + "LoadThread", this.LoadThread);
            this.SetParamSimple(map, prefix + "SinkerThread", this.SinkerThread);
            this.SetParamSimple(map, prefix + "LoadRps", this.LoadRps);
        }
    }
}

