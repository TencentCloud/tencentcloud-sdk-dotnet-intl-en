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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConcurrencyLimitDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Call source (subject_type determines the meaning of subject_id/subject_name. For example, for APP, subject_id=app_id and subject_name=app_name)</p>
        /// </summary>
        [JsonProperty("CallSource")]
        public CallSource CallSource{ get; set; }

        /// <summary>
        /// <p>Time when the limit was exceeded (Unix seconds)</p>
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// <p>Model name</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Request content (the original query text of the user request)</p>
        /// </summary>
        [JsonProperty("RequestQuery")]
        public string RequestQuery{ get; set; }

        /// <summary>
        /// <p>Space ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CallSource.", this.CallSource);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "RequestQuery", this.RequestQuery);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
        }
    }
}

