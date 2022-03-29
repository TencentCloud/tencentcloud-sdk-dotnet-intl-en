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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the input audio moderation task information. For the specific input content, see the detailed description of the `TaskInput` data structure.<br>Note: you can create up to **10 tasks** at a time.
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskInput[] Tasks{ get; set; }

        /// <summary>
        /// This field indicates the specific number of the policy, which is used for API scheduling and can be configured in the CMS console. If the `Biztype` parameter is passed in, a moderation policy will be used based on the business scenario; otherwise, the default moderation policy will be used.<br>Note: `Biztype` can contain 3–32 digits, letters, and underscores; different `Biztype` values are associated with different business scenarios and moderation policies, so you need to verify the `Biztype` before calling this API.
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// This field indicates the input audio moderation type. Valid values: **AUDIO** (audio on demand), **LIVE_AUDIO** (audio live streaming). Default value: AUDIO.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This field is optional and indicates the key information of the callback signature, which is used to ensure the data security. The signature algorithm is to add the `X-Signature` field to the returned HTTP header, whose value is the SHA256-encoded hex string of `seed` + `body` . After receiving the callback data, you can calculate `X-Signature` by using **sha256(seed + body)** based on the returned `body` for verification.<br>For specific use cases, see [Signature Algorithm v3](https://intl.cloud.tencent.com/document/product/1219/53263?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// This field is optional and indicates the address for receiving the moderation information callback in the default format of URL. After it is configured successfully, the non-compliant audio/video segments generated during moderation will be sent through this API. For the format of the returned callback content, see [Sample Callback Signature](https://intl.cloud.tencent.com/document/product/1219/53257?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B2-.E5.9B.9E.E8.B0.83.E7.AD.BE.E5.90.8D.E7.A4.BA.E4.BE.8B)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

