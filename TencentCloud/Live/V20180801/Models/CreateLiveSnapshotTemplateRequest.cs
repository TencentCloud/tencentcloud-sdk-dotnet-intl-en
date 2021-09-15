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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveSnapshotTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name.
        /// Maximum length: 255 bytes.
        /// Only letters, digits, underscores, and hyphens can be contained.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// COS application ID.
        /// </summary>
        [JsonProperty("CosAppId")]
        public long? CosAppId{ get; set; }

        /// <summary>
        /// COS bucket name.
        /// Note: the value of `CosBucket` cannot contain `-[appid]`.
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// COS region.
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// Description.
        /// Maximum length: 1,024 bytes.
        /// Only letters, digits, underscores, and hyphens can be contained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Screencapturing interval in seconds. Default value: 10s.
        /// Value range: 5-300s.
        /// </summary>
        [JsonProperty("SnapshotInterval")]
        public long? SnapshotInterval{ get; set; }

        /// <summary>
        /// Screenshot width. Default value: `0` (original width)
        /// Value range: 0-3000
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Screenshot height. Default value: `0` (original height)
        /// Value range: 0-2000
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Whether to enable porn detection. 0: no, 1: yes. Default value: 0
        /// </summary>
        [JsonProperty("PornFlag")]
        public long? PornFlag{ get; set; }

        /// <summary>
        /// COS Bucket folder prefix.
        /// If no value is entered, the default value
        /// `/{Year}-{Month}-{Day}`
        /// will be used.
        /// </summary>
        [JsonProperty("CosPrefix")]
        public string CosPrefix{ get; set; }

        /// <summary>
        /// COS filename.
        /// If no value is entered, the default value 
        /// `{StreamID}-screenshot-{Hour}-{Minute}-{Second}-{Width}x{Height}{Ext}`
        /// will be used.
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "CosAppId", this.CosAppId);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SnapshotInterval", this.SnapshotInterval);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "PornFlag", this.PornFlag);
            this.SetParamSimple(map, prefix + "CosPrefix", this.CosPrefix);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
        }
    }
}

