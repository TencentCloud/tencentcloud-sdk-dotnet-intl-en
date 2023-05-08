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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaResultRequest : AbstractModel
    {
        
        /// <summary>
        /// It must be `9` here. You can configure the CAPTCHA types in the console.
        /// </summary>
        [JsonProperty("CaptchaType")]
        public ulong? CaptchaType{ get; set; }

        /// <summary>
        /// The user verification ticket returned by the frontend callback function
        /// </summary>
        [JsonProperty("Ticket")]
        public string Ticket{ get; set; }

        /// <summary>
        /// The user public IP obtained from the customer backend server
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// A random string returned by the frontend callback function
        /// </summary>
        [JsonProperty("Randstr")]
        public string Randstr{ get; set; }

        /// <summary>
        /// CAPTCHA's app ID. Log in to the [Captcha console](https://console.cloud.tencent.com/captcha/graphical) and you can view the CaptchaAppId in the "Key" column of the CAPTCHA list.
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public ulong? CaptchaAppId{ get; set; }

        /// <summary>
        /// CAPTCHA's app key. Log in to the [Captcha console](https://console.cloud.tencent.com/captcha/graphical) and you can view the AppSecretKey in the "Key" column of the CAPTCHA list. AppSecretKey is the key for CAPTCHA ticket verification performed by the server. Please keep it confidential and do not disclose it to any third parties.
        /// </summary>
        [JsonProperty("AppSecretKey")]
        public string AppSecretKey{ get; set; }

        /// <summary>
        /// Reserved field.
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// Reserved field.
        /// </summary>
        [JsonProperty("SceneId")]
        public ulong? SceneId{ get; set; }

        /// <summary>
        /// MAC address or unique identifier of a device
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// Mobile equipment identity number
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// Indicates whether to return the time when the frontend obtains the CAPTCHA. Valid values: 1 (return the time) and others.
        /// </summary>
        [JsonProperty("NeedGetCaptchaTime")]
        public long? NeedGetCaptchaTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaType", this.CaptchaType);
            this.SetParamSimple(map, prefix + "Ticket", this.Ticket);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Randstr", this.Randstr);
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppSecretKey", this.AppSecretKey);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "NeedGetCaptchaTime", this.NeedGetCaptchaTime);
        }
    }
}

