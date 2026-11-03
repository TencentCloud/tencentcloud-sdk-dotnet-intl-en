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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSessionTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// MFA serial number, the identifier of the MFA device associated with the CAM user making the call. Format: qcs::CAM:uin/${ownerUin}::MFA/${mfaType}. mfaType supports softToken.
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// mfa identity verification code.
        /// </summary>
        [JsonProperty("TokenCode")]
        public string TokenCode{ get; set; }

        /// <summary>
        /// Validity period of the specified temporary certificate. Unit: second. Default value: 1800 seconds. The root account can set a validity period of up to 7200 seconds, and a sub-account can set a validity period of up to 129600 seconds.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public long? DurationSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "TokenCode", this.TokenCode);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
        }
    }
}

