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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRotationStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Tencent Cloud service credential name.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Specifies whether to enable rotation.
        /// True: enable rotation.
        /// False: disable rotation.
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// Rotation frequency in days. Value range: 30–365.
        /// </summary>
        [JsonProperty("Frequency")]
        public long? Frequency{ get; set; }

        /// <summary>
        /// User-Defined rotation start time in the format of 2006-01-02 15:04:05.
        /// When `EnableRotation` is `True`, if `RotationBeginTime` is left empty, the current time will be entered by default.
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
        }
    }
}

