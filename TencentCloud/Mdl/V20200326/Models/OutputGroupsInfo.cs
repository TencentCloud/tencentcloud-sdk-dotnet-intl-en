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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputGroupsInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Output protocol type.
        /// Valid values: HLS, DASH, HLS_ARCHIVE, HLS_MEDIA_PACKAGE, DASH_MEDIA_PACKAGE.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputInfo[] Outputs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Destinations")]
        public DestinationInfo[] Destinations{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HlsRemuxSettings")]
        public HlsRemuxSettingsInfo HlsRemuxSettings{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DashRemuxSettings")]
        public DashRemuxSettingsInfo DashRemuxSettings{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DrmSettings")]
        public DrmSettingsInfo DrmSettings{ get; set; }

        /// <summary>
        /// Configuration information of media packaging, which is required when `Type` is set to MediaPackage.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MediaPackageSettings")]
        public MediaPackageSettingsInfo MediaPackageSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamObj(map, prefix + "HlsRemuxSettings.", this.HlsRemuxSettings);
            this.SetParamObj(map, prefix + "DashRemuxSettings.", this.DashRemuxSettings);
            this.SetParamObj(map, prefix + "DrmSettings.", this.DrmSettings);
            this.SetParamObj(map, prefix + "MediaPackageSettings.", this.MediaPackageSettings);
        }
    }
}

