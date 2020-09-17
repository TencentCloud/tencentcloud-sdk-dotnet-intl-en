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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamLayout : AbstractModel
    {
        
        /// <summary>
        /// Stream layout configuration
        /// </summary>
        [JsonProperty("LayoutParams")]
        public LayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// Video stream ID
        /// Description of the possible video stream ID values:
        /// 1. tic_record_user: the current picture is used to display the whiteboard video stream.
        /// 2. tic_substream: the current picture is used to display the auxiliary video stream.
        /// 3. Specific user ID: the current picture is used to display the video stream of a specific user.
        /// 4.Left empty: the current picture is vacant for new video stream.
        /// </summary>
        [JsonProperty("InputStreamId")]
        public string InputStreamId{ get; set; }

        /// <summary>
        /// Background color in RGB format, such as "#FF0000" for red. The default color is black. 
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }

        /// <summary>
        /// Video filling mode.
        /// 
        /// 0: self-adaption mode. Scales the video proportionally to completely display it in the specified area. In this mode, there may be black bars.
        /// 1: full-screen mode. Scales the video to make it fill the entire specified area. In this mode, no black bars will appear, but the video may not be displayed fully.
        /// </summary>
        [JsonProperty("FillMode")]
        public long? FillMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamSimple(map, prefix + "InputStreamId", this.InputStreamId);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
            this.SetParamSimple(map, prefix + "FillMode", this.FillMode);
        }
    }
}

