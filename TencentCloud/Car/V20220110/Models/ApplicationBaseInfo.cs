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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// Application window usage mode (ApplicationDesktop: Captures the entire desktop; ApplicationWindow: Captures only the application window).
        /// </summary>
        [JsonProperty("WindowUseType")]
        public string WindowUseType{ get; set; }

        /// <summary>
        /// Application window name.
        /// </summary>
        [JsonProperty("WindowName")]
        public string WindowName{ get; set; }

        /// <summary>
        /// Application window class name.
        /// </summary>
        [JsonProperty("WindowClassName")]
        public string WindowClassName{ get; set; }

        /// <summary>
        /// Application window capture mode (HOOK: default mode; DDA_CUT: compatible mode).
        /// </summary>
        [JsonProperty("WindowCaptureMode")]
        public string WindowCaptureMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WindowUseType", this.WindowUseType);
            this.SetParamSimple(map, prefix + "WindowName", this.WindowName);
            this.SetParamSimple(map, prefix + "WindowClassName", this.WindowClassName);
            this.SetParamSimple(map, prefix + "WindowCaptureMode", this.WindowCaptureMode);
        }
    }
}

