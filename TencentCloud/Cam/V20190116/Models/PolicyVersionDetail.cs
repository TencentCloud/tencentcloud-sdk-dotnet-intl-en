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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyVersionDetail : AbstractModel
    {
        
        /// <summary>
        /// Policy version ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VersionId")]
        public ulong? VersionId{ get; set; }

        /// <summary>
        /// Policy version creation time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// Whether it is the operative version. 0: no, 1: yes
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDefaultVersion")]
        public ulong? IsDefaultVersion{ get; set; }

        /// <summary>
        /// Policy syntax text
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Document")]
        public string Document{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "IsDefaultVersion", this.IsDefaultVersion);
            this.SetParamSimple(map, prefix + "Document", this.Document);
        }
    }
}

