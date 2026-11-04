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

    public class AuditLog : AbstractModel
    {
        
        /// <summary>
        /// <p>Employee information</p>
        /// </summary>
        [JsonProperty("AccountInfo")]
        public AccountInfo AccountInfo{ get; set; }

        /// <summary>
        /// <p>Application business id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Application name</p><p>Name when the operation log is triggered</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>Operation time</p><p>Parameter format: timestamp in seconds</p>
        /// </summary>
        [JsonProperty("OperateTime")]
        public string OperateTime{ get; set; }

        /// <summary>
        /// <p>Operation type.</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Operation object.</p>
        /// </summary>
        [JsonProperty("Biz")]
        public string Biz{ get; set; }

        /// <summary>
        /// <p>Operation content</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Unique ID for the operation.</p>
        /// </summary>
        [JsonProperty("UniqueId")]
        public string UniqueId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AccountInfo.", this.AccountInfo);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "OperateTime", this.OperateTime);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Biz", this.Biz);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "UniqueId", this.UniqueId);
        }
    }
}

