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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Color value.
        /// </summary>
        [JsonProperty("ColorCode")]
        public string ColorCode{ get; set; }

        /// <summary>
        /// Icon.
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// Available upon request.
        /// </summary>
        [JsonProperty("IsApply")]
        public bool? IsApply{ get; set; }

        /// <summary>
        /// Seed.
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// Default dashboard.
        /// </summary>
        [JsonProperty("DefaultPanelType")]
        public long? DefaultPanelType{ get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonProperty("PanelScope")]
        public string PanelScope{ get; set; }

        /// <summary>
        /// Project management platform.
        /// </summary>
        [JsonProperty("ManagePlatform")]
        public string ManagePlatform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ColorCode", this.ColorCode);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "IsApply", this.IsApply);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "DefaultPanelType", this.DefaultPanelType);
            this.SetParamSimple(map, prefix + "PanelScope", this.PanelScope);
            this.SetParamSimple(map, prefix + "ManagePlatform", this.ManagePlatform);
        }
    }
}

