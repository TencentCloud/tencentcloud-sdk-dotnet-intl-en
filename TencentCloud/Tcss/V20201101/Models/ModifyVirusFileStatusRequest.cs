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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirusFileStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// IDs of events
        /// </summary>
        [JsonProperty("EventIdSet")]
        public string[] EventIdSet{ get; set; }

        /// <summary>
        /// Event status   
        ///     `EVENT_DEALED`: Processed.
        ///     `EVENT_INGNORE`: Ignored.
        ///     `EVENT_DEL`: Deleted.
        ///     `EVENT_ADD_WHITE`: Allowed.
        ///     `EVENT_PENDING`: Pending.
        /// 	`EVENT_ISOLATE_CONTAINER`: Container isolated.
        /// 	`EVENT_RESOTRE_CONTAINER`: Container recovered.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Event remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Whether to automatically isolate files with the same MD5 checksum
        /// </summary>
        [JsonProperty("AutoIsolate")]
        public bool? AutoIsolate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventIdSet.", this.EventIdSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AutoIsolate", this.AutoIsolate);
        }
    }
}

