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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAigcAdvancedCustomElementRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Subject name, cannot exceed 20 characters.</p>
        /// </summary>
        [JsonProperty("ElementName")]
        public string ElementName{ get; set; }

        /// <summary>
        /// <p>Subject description, up to 100 characters.</p>
        /// </summary>
        [JsonProperty("ElementDescription")]
        public string ElementDescription{ get; set; }

        /// <summary>
        /// <p>Subject reference method. The availability of subjects customized via video and via image is different.</p><p>Enumeration values:</p><ul><li>video_refer: Video role subject. At this point, refer to element_video_list to define the subject appearance.</li><li>image_refer: Multi-image subject. At this point, refer to element_image_list to define the subject appearance.</li></ul>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// <p>Entity voice type, can bind existing timbres in the timbre library.</p><ul><li>When the current parameter is empty, the current entity is not bound to a timbre.</li><li>Only entities customized for video support binding timbres.</li></ul>
        /// </summary>
        [JsonProperty("ElementVoiceId")]
        public string ElementVoiceId{ get; set; }

        /// <summary>
        /// <p>Entity reference video, used to set the entity and its details through video.</p><ul><li>Videos with audio can be uploaded. If the video contains voice, it triggers custom timbre (customize + add to timbre library + bind with entity).</li><li>Required when referencing a video, unavailable when referencing an image.</li><li>Carried in key:value format, as follows:<br><pre><code>{  &quot;refer_videos&quot;:[    {      &quot;video_url&quot;:&quot;video_url_1&quot;    }  ]}</code></pre>● Only MP4/MOV video formats are supported.<br>● Only 1080P videos with a duration between 3s and 8s and an aspect ratio of 16:9 or 9:16 are supported.<br>● Up to 1 video can be uploaded, with a video size no more than 200MB.<br>● The video_url parameter value cannot be empty.</li></ul>
        /// </summary>
        [JsonProperty("ElementVideoList")]
        public string ElementVideoList{ get; set; }

        /// <summary>
        /// <p>Subject reference image. You can set the subject and its details through multiple images.</p><ul><li>Including a front reference image and other angle or close-up reference images. Among them:<ul><li>At least 1 front reference image, defined by the frontal_image parameter.</li><li>1–3 other reference images, which must differ from the front reference image, defined by the image_url parameter.</li></ul></li><li>Use key:value to carry them, as follows:<br><pre><code>{  "frontal_image":"image_url_0",  "refer_images":[    {      "image_url":"image_url_1"    },    {      "image_url":"image_url_2"    },    {      "image_url":"image_url_3"    }  ]}</code></pre></li></ul>
        /// </summary>
        [JsonProperty("ElementImageList")]
        public string ElementImageList{ get; set; }

        /// <summary>
        /// <p>Configure tags for a principal. A principal can be configured with multiple tags.</p><ul><li>Use key:value to carry them. Among them, details are given below:</li></ul><p><pre><code>[  {        &quot;tag_id&quot;: &quot;o_101&quot;  }, {        &quot;tag_id&quot;: &quot;o_102&quot;    }]</code></pre></p>
        /// </summary>
        [JsonProperty("TagList")]
        public string TagList{ get; set; }

        /// <summary>
        /// <p>If the overseas custom subject library is enabled, you can pass in <code>True</code> to use it.</p><p>Enumeration values:</p><ul><li>True: Use the overseas custom subject library.</li><li>False: Do not use the overseas custom subject library.</li></ul>
        /// </summary>
        [JsonProperty("DisableModeration")]
        public string DisableModeration{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The task complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task priority. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ElementName", this.ElementName);
            this.SetParamSimple(map, prefix + "ElementDescription", this.ElementDescription);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "ElementVoiceId", this.ElementVoiceId);
            this.SetParamSimple(map, prefix + "ElementVideoList", this.ElementVideoList);
            this.SetParamSimple(map, prefix + "ElementImageList", this.ElementImageList);
            this.SetParamSimple(map, prefix + "TagList", this.TagList);
            this.SetParamSimple(map, prefix + "DisableModeration", this.DisableModeration);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

