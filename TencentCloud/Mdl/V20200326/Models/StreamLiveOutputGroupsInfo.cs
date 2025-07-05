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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamLiveOutputGroupsInfo : AbstractModel
    {
        
        /// <summary>
        /// Output group name, which can contain 1-32 case-sensitive letters, digits, and underscores and must be unique at the channel level
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Output protocol
        /// Valid values: `HLS`, `DASH`, `HLS_ARCHIVE`, 
        ///  `DASH_ARCHIVE`, `HLS_STREAM_PACKAGE`, 
        ///  `DASH_STREAM_PACKAGE`, 
        ///  `FRAME_CAPTURE`, `RTP`, `RTMP`, `M2TS`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Output information
        /// If the type is RTMP, RTP or FRAME_CAPTURE, only one output is allowed; if it is HLS or DASH, 1-10 outputs are allowed.
        /// </summary>
        [JsonProperty("Outputs")]
        public OutputInfo[] Outputs{ get; set; }

        /// <summary>
        /// Relay destinations. Quantity: [1, 2]
        /// </summary>
        [JsonProperty("Destinations")]
        public DestinationInfo[] Destinations{ get; set; }

        /// <summary>
        /// HLS protocol configuration information, which takes effect only for HLS/HLS_ARCHIVE/HLS_STREAM_PACKAGE outputs.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("HlsRemuxSettings")]
        public HlsRemuxSettingsInfo HlsRemuxSettings{ get; set; }

        /// <summary>
        /// DRM configuration information
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DrmSettings")]
        public DrmSettingsInfo DrmSettings{ get; set; }

        /// <summary>
        /// DASH protocol configuration information, which takes effect only for DASH/DASH_ARCHIVE outputs
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DashRemuxSettings")]
        public DashRemuxSettingsInfo DashRemuxSettings{ get; set; }

        /// <summary>
        /// StreamPackage configuration information, which is required if the output type is StreamPackage
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StreamPackageSettings")]
        public StreamPackageSettingsInfo StreamPackageSettings{ get; set; }

        /// <summary>
        /// Time-shift configuration information
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("TimeShiftSettings")]
        public TimeShiftSettingsInfo TimeShiftSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamObj(map, prefix + "HlsRemuxSettings.", this.HlsRemuxSettings);
            this.SetParamObj(map, prefix + "DrmSettings.", this.DrmSettings);
            this.SetParamObj(map, prefix + "DashRemuxSettings.", this.DashRemuxSettings);
            this.SetParamObj(map, prefix + "StreamPackageSettings.", this.StreamPackageSettings);
            this.SetParamObj(map, prefix + "TimeShiftSettings.", this.TimeShiftSettings);
        }
    }
}

