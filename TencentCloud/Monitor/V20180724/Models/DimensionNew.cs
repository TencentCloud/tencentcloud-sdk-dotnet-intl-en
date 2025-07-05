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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DimensionNew : AbstractModel
    {
        
        /// <summary>
        /// Dimension key ID displayed on the backend
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Dimension key name displayed on the frontend
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether it is required
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// List of supported operators
        /// </summary>
        [JsonProperty("Operators")]
        public Operator[] Operators{ get; set; }

        /// <summary>
        /// Whether multiple items can be selected
        /// </summary>
        [JsonProperty("IsMultiple")]
        public bool? IsMultiple{ get; set; }

        /// <summary>
        /// Whether it can be modified after creation
        /// </summary>
        [JsonProperty("IsMutable")]
        public bool? IsMutable{ get; set; }

        /// <summary>
        /// Whether it is displayed to users
        /// </summary>
        [JsonProperty("IsVisible")]
        public bool? IsVisible{ get; set; }

        /// <summary>
        /// Whether it can be used to filter policies
        /// </summary>
        [JsonProperty("CanFilterPolicy")]
        public bool? CanFilterPolicy{ get; set; }

        /// <summary>
        /// Whether it can be used to filter historical alarms
        /// </summary>
        [JsonProperty("CanFilterHistory")]
        public bool? CanFilterHistory{ get; set; }

        /// <summary>
        /// Whether it can be used as an aggregate dimension
        /// </summary>
        [JsonProperty("CanGroupBy")]
        public bool? CanGroupBy{ get; set; }

        /// <summary>
        /// Whether it must be used as an aggregate dimension
        /// </summary>
        [JsonProperty("MustGroupBy")]
        public bool? MustGroupBy{ get; set; }

        /// <summary>
        /// The key to be replaced on the frontend
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShowValueReplace")]
        public string ShowValueReplace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamArrayObj(map, prefix + "Operators.", this.Operators);
            this.SetParamSimple(map, prefix + "IsMultiple", this.IsMultiple);
            this.SetParamSimple(map, prefix + "IsMutable", this.IsMutable);
            this.SetParamSimple(map, prefix + "IsVisible", this.IsVisible);
            this.SetParamSimple(map, prefix + "CanFilterPolicy", this.CanFilterPolicy);
            this.SetParamSimple(map, prefix + "CanFilterHistory", this.CanFilterHistory);
            this.SetParamSimple(map, prefix + "CanGroupBy", this.CanGroupBy);
            this.SetParamSimple(map, prefix + "MustGroupBy", this.MustGroupBy);
            this.SetParamSimple(map, prefix + "ShowValueReplace", this.ShowValueReplace);
        }
    }
}

