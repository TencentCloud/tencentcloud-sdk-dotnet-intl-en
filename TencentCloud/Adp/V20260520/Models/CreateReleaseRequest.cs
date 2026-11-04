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

    public class CreateReleaseRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>App sharing access control configuration</p>
        /// </summary>
        [JsonProperty("AppShareAccessControl")]
        public AppShareAccessControl AppShareAccessControl{ get; set; }

        /// <summary>
        /// <p>Channel ID list</p>
        /// </summary>
        [JsonProperty("ChannelIdList")]
        public string[] ChannelIdList{ get; set; }

        /// <summary>
        /// <p>Business shared configuration</p>
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public CorpShareConfig CorpShareConfig{ get; set; }

        /// <summary>
        /// <p>Release description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Batch change the debug-only knowledge in the default knowledge base to "effective in both debug and release"</p>
        /// </summary>
        [JsonProperty("IsDevToRelease")]
        public bool? IsDevToRelease{ get; set; }

        /// <summary>
        /// <p>Whether to synchronize publishing as an application template</p>
        /// </summary>
        [JsonProperty("IsPublishAsTemplate")]
        public bool? IsPublishAsTemplate{ get; set; }

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
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamObj(map, prefix + "AppShareAccessControl.", this.AppShareAccessControl);
            this.SetParamArraySimple(map, prefix + "ChannelIdList.", this.ChannelIdList);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsDevToRelease", this.IsDevToRelease);
            this.SetParamSimple(map, prefix + "IsPublishAsTemplate", this.IsPublishAsTemplate);
            this.SetParamObj(map, prefix + "PortalShareConfig.", this.PortalShareConfig);
        }
    }
}

