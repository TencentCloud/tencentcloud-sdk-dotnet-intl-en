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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInfoV2 : AbstractModel
    {
        
        /// <summary>
        /// <p>Image type.</p><p>Enumeration values:</p><ul><li>official: official image</li><li>custom: custom image</li><li>imageUrl: image URL</li></ul>
        /// </summary>
        [JsonProperty("ImageMode")]
        public string ImageMode{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Whether it is an existing image.</p>
        /// </summary>
        [JsonProperty("LegacyCCR")]
        public bool? LegacyCCR{ get; set; }

        /// <summary>
        /// <p>Image URL.</p>
        /// </summary>
        [JsonProperty("FullImageUrl")]
        public string FullImageUrl{ get; set; }

        /// <summary>
        /// <p>Version.</p>
        /// </summary>
        [JsonProperty("MainVersion")]
        public string MainVersion{ get; set; }

        /// <summary>
        /// <p>Image URL domain name.</p>
        /// </summary>
        [JsonProperty("RegistryUrl")]
        public string RegistryUrl{ get; set; }

        /// <summary>
        /// <p>Image namespace.</p>
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// <p>Image repository name.</p>
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// <p>Image version tag.</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>Username.</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Password.</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Image pull secret.</p>
        /// </summary>
        [JsonProperty("ImagePullSecret")]
        public ImagePullSecret ImagePullSecret{ get; set; }

        /// <summary>
        /// <p>Image pull policy.</p>
        /// </summary>
        [JsonProperty("ImagePullPolicy")]
        public string ImagePullPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageMode", this.ImageMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "LegacyCCR", this.LegacyCCR);
            this.SetParamSimple(map, prefix + "FullImageUrl", this.FullImageUrl);
            this.SetParamSimple(map, prefix + "MainVersion", this.MainVersion);
            this.SetParamSimple(map, prefix + "RegistryUrl", this.RegistryUrl);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "ImagePullSecret.", this.ImagePullSecret);
            this.SetParamSimple(map, prefix + "ImagePullPolicy", this.ImagePullPolicy);
        }
    }
}

