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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuTencentVod : AbstractModel
    {
        
        /// <summary>
        /// Post-Upload Task Processing
        /// Automatically initiates task flows after media uploads complete. Value = Task flow template name.
        /// VOD supports creating and naming task flow templates.
        /// Example: template_name
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// Media File Expiration Time
        /// Absolute expiration time from current timestamp.
        /// 86400 = 1 day retention
        /// 0 = permanent storage (default)
        /// Example: 86400
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// Upload Region Specification
        /// For users requiring specific upload regions.
        /// Example: ap-shanghai
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// Category ID
        /// Manages media classification. Obtain via category creation API.
        /// Default: 0 (Other category)
        /// Example: 0
        /// </summary>
        [JsonProperty("ClassId")]
        public ulong? ClassId{ get; set; }

        /// <summary>
        /// VOD SubAppId
        /// Required when accessing sub-application resources. Leave empty otherwise.
        /// Example: 0
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Task Flow Context
        /// Passed through in task completion callbacks.
        /// Example: user_custom
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Upload Context
        /// Passed through in upload completion callbacks.
        /// Example: user_custom
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
        }
    }
}

