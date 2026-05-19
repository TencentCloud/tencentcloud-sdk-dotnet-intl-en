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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubAppIdRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application name, length limited to 40 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Application description, length limited to 300 characters. If left blank, the application description is empty by default.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>App type. Valid values: <li>AllInOne: integrated;</li><li>Professional: pro edition.</li>Default value: AllInOne.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Mode of this application. Available values are:</p><ul><li>fileid: fileid mode only</li><li>fileid+path: fileid & path mode<br>Leave empty to select fileid mode by default</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>When Mode is fileid only, it is used to set the default storage region and is selectable.<br>When Mode is fileid+path, it is used to specify the storage region and is required.</p><p>For reference: <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1">Supported region list</a></p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p>tag that needs to be bound to this application</p>
        /// </summary>
        [JsonProperty("Tags")]
        public ResourceTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

