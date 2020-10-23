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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditMediaTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Input video source type. Valid values: File, Stream.
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// Information of input video file. This field has a value only when `InputType` is `File`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileInfoSet")]
        public EditMediaFileInfo[] FileInfoSet{ get; set; }

        /// <summary>
        /// Input stream information. This field has a value only when `InputType` is `Stream`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StreamInfoSet")]
        public EditMediaStreamInfo[] StreamInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamArrayObj(map, prefix + "FileInfoSet.", this.FileInfoSet);
            this.SetParamArrayObj(map, prefix + "StreamInfoSet.", this.StreamInfoSet);
        }
    }
}

