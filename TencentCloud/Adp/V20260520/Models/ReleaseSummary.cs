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

    public class ReleaseSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Creation time (Unix timestamp, in seconds)</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Release description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Release ID</p>
        /// </summary>
        [JsonProperty("ReleaseId")]
        public string ReleaseId{ get; set; }

        /// <summary>
        /// <p>Released status. Enumeration values: 1: To be released, 2: Releasing, 3: Released successfully, 4: Release failure, 5: Under review, 6: Review successful, 7: Review failed, 8: Callback processing for successful release, 9: Release suspension, 10: Appeal under review, 11: Appeal passed, 12: Appeal not approved</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Status description.</p>
        /// </summary>
        [JsonProperty("StatusDescription")]
        public string StatusDescription{ get; set; }

        /// <summary>
        /// <p>Application sharing access control</p>
        /// </summary>
        [JsonProperty("AppShareAccessControl")]
        public AppShareAccessControl AppShareAccessControl{ get; set; }

        /// <summary>
        /// <p>Release channel ID list</p>
        /// </summary>
        [JsonProperty("ChannelIdList")]
        public string[] ChannelIdList{ get; set; }

        /// <summary>
        /// <p>Business shared configuration</p>
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public CorpShareConfig CorpShareConfig{ get; set; }

        /// <summary>
        /// <p>portal configuration</p>
        /// </summary>
        [JsonProperty("PortalShareConfig")]
        public PortalShareConfig PortalShareConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ReleaseId", this.ReleaseId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDescription", this.StatusDescription);
            this.SetParamObj(map, prefix + "AppShareAccessControl.", this.AppShareAccessControl);
            this.SetParamArraySimple(map, prefix + "ChannelIdList.", this.ChannelIdList);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
            this.SetParamObj(map, prefix + "PortalShareConfig.", this.PortalShareConfig);
        }
    }
}

