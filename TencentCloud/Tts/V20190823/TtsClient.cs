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

namespace TencentCloud.Tts.V20190823
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tts.V20190823.Models;

   public class TtsClient : AbstractClient{

       private const string endpoint = "tts.tencentcloudapi.com";
       private const string version = "2019-08-23";
       private const string sdkVersion = "SDK_NET_3.0.918";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to convert any text to speech, allowing your devices and applications to talk to users.
        /// u200bTencent Cloud Text To Speech (TTS) can synthesize speech from text in real time for many use cases, such as audiobook and news apps, voice reminders on smart devices, quick synthesis of a celebrity's voice based on existing programs or certain voice records available on the internet, and personalized vehicle navigation systems.
        /// It is free for use in beta.
        /// It supports SSML. For syntax details, see [SSML](https://intl.cloud.tencent.com/document/product/1073/49575?from_cn_redirect=1).
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public Task<TextToVoiceResponse> TextToVoice(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice");
        }

        /// <summary>
        /// This API is used to convert any text to speech, allowing your devices and applications to talk to users.
        /// u200bTencent Cloud Text To Speech (TTS) can synthesize speech from text in real time for many use cases, such as audiobook and news apps, voice reminders on smart devices, quick synthesis of a celebrity's voice based on existing programs or certain voice records available on the internet, and personalized vehicle navigation systems.
        /// It is free for use in beta.
        /// It supports SSML. For syntax details, see [SSML](https://intl.cloud.tencent.com/document/product/1073/49575?from_cn_redirect=1).
        /// Default API request rate limit: 20 requests/sec.
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public TextToVoiceResponse TextToVoiceSync(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
