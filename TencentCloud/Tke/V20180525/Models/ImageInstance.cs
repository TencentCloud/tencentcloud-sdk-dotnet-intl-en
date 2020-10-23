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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInstance : AbstractModel
    {
        
        /// <summary>
        /// Image alias
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Operating system name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Image ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Container image tag, **DOCKER_CUSTOMIZE** (container customized tag), **GENERAL** (general tag, default value)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
        }
    }
}

