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

namespace TencentCloud.Tcmpp.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNPVersionCompileTaskExtInfo : AbstractModel
    {
        
        /// <summary>
        /// TCMPP error message
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TCMPPErrMsg")]
        public string TCMPPErrMsg{ get; set; }

        /// <summary>
        /// WX Error Message
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WXErrMsg")]
        public string WXErrMsg{ get; set; }

        /// <summary>
        /// WeChat QR code
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WXQrCode")]
        public string WXQrCode{ get; set; }

        /// <summary>
        /// Compile size Information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SizeInfo")]
        public string SizeInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TCMPPErrMsg", this.TCMPPErrMsg);
            this.SetParamSimple(map, prefix + "WXErrMsg", this.WXErrMsg);
            this.SetParamSimple(map, prefix + "WXQrCode", this.WXQrCode);
            this.SetParamSimple(map, prefix + "SizeInfo", this.SizeInfo);
        }
    }
}

