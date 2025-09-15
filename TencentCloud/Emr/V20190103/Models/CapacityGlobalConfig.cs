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

    public class CapacityGlobalConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether label-based scheduling is enabled.
        /// </summary>
        [JsonProperty("EnableLabel")]
        public bool? EnableLabel{ get; set; }

        /// <summary>
        /// Path for tag information storage if label-based scheduling is enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LabelDir")]
        public string LabelDir{ get; set; }

        /// <summary>
        /// Whether to overwrite the user-specified queue, wherein true indicates overwrite.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueueMappingOverride")]
        public bool? QueueMappingOverride{ get; set; }

        /// <summary>
        /// Advanced settings.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultSettings")]
        public DefaultSetting[] DefaultSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableLabel", this.EnableLabel);
            this.SetParamSimple(map, prefix + "LabelDir", this.LabelDir);
            this.SetParamSimple(map, prefix + "QueueMappingOverride", this.QueueMappingOverride);
            this.SetParamArrayObj(map, prefix + "DefaultSettings.", this.DefaultSettings);
        }
    }
}

