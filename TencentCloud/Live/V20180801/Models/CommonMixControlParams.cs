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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixControlParams : AbstractModel
    {
        
        /// <summary>
        /// Value range: [0,1]. 
        /// If 1 is entered, when the layer resolution in the parameter is different from the actual video resolution, the video will be automatically cropped according to the resolution set by the layer.
        /// </summary>
        [JsonProperty("UseMixCropCenter")]
        public long? UseMixCropCenter{ get; set; }

        /// <summary>
        /// Value range: [0,1].
        /// If this parameter is set to 1, when both `InputStreamList` and `OutputParams.OutputStreamType` are set to 1, you can copy a stream instead of canceling it.
        /// </summary>
        [JsonProperty("AllowCopy")]
        public long? AllowCopy{ get; set; }

        /// <summary>
        /// Valid values: 0, 1
        /// If you set this parameter to 1, SEI (Supplemental Enhanced Information) of the input streams will be passed through.
        /// </summary>
        [JsonProperty("PassInputSei")]
        public long? PassInputSei{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UseMixCropCenter", this.UseMixCropCenter);
            this.SetParamSimple(map, prefix + "AllowCopy", this.AllowCopy);
            this.SetParamSimple(map, prefix + "PassInputSei", this.PassInputSei);
        }
    }
}

