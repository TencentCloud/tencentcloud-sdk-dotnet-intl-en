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

namespace TencentCloud.Gme.V20180711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gme.V20180711.Models;

   public class GmeClient : AbstractClient{

       private const string endpoint = "gme.tencentcloudapi.com";
       private const string version = "2018-07-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GmeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GmeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public async Task<CreateAppResponse> CreateApp(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a GME application.
        /// </summary>
        /// <param name="req"><see cref="CreateAppRequest"/></param>
        /// <returns><see cref="CreateAppResponse"/></returns>
        public CreateAppResponse CreateAppSync(CreateAppRequest req)
        {
             JsonResponseModel<CreateAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public async Task<DeleteRoomMemberResponse> DeleteRoomMember(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room or remove members from the room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomMemberRequest"/></param>
        /// <returns><see cref="DeleteRoomMemberResponse"/></returns>
        public DeleteRoomMemberResponse DeleteRoomMemberSync(DeleteRoomMemberRequest req)
        {
             JsonResponseModel<DeleteRoomMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoomMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public async Task<DescribeAppStatisticsResponse> DescribeAppStatistics(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the usage statistics of a GME application, including those of Voice Chat, Voice Message Service, Voice Analysis, etc. The maximum query period is the past 30 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeAppStatisticsRequest"/></param>
        /// <returns><see cref="DescribeAppStatisticsResponse"/></returns>
        public DescribeAppStatisticsResponse DescribeAppStatisticsSync(DescribeAppStatisticsRequest req)
        {
             JsonResponseModel<DescribeAppStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAppStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public async Task<DescribeApplicationDataResponse> DescribeApplicationData(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query data details for up to the past 90 days.
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationDataRequest"/></param>
        /// <returns><see cref="DescribeApplicationDataResponse"/></returns>
        public DescribeApplicationDataResponse DescribeApplicationDataSync(DescribeApplicationDataRequest req)
        {
             JsonResponseModel<DescribeApplicationDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of voice moderation tasks. Up to 100 tasks can be queried in one time.
        /// <p style="color:red">If the `Callback` field is not set when a voice moderation task is submitted, this API is called to query the moderation result.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultListRequest"/></param>
        /// <returns><see cref="DescribeScanResultListResponse"/></returns>
        public async Task<DescribeScanResultListResponse> DescribeScanResultList(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of voice moderation tasks. Up to 100 tasks can be queried in one time.
        /// <p style="color:red">If the `Callback` field is not set when a voice moderation task is submitted, this API is called to query the moderation result.</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultListRequest"/></param>
        /// <returns><see cref="DescribeScanResultListResponse"/></returns>
        public DescribeScanResultListResponse DescribeScanResultListSync(DescribeScanResultListRequest req)
        {
             JsonResponseModel<DescribeScanResultListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanResultList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public async Task<ModifyAppStatusResponse> ModifyAppStatus(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to change the status of an application.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppStatusRequest"/></param>
        /// <returns><see cref="ModifyAppStatusResponse"/></returns>
        public ModifyAppStatusResponse ModifyAppStatusSync(ModifyAppStatusRequest req)
        {
             JsonResponseModel<ModifyAppStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAppStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a voice detection task. Up to 100 tasks can be added in the detection task list. Before using this API, please activate the Voice Content Moderation Service in [GME Console > Voice Content Moderation > Service Configuration](https://console.cloud.tencent.com/gamegme/conf).
        /// </br></br>
        /// 
        /// <h4><b>About the trial:</b></h4>
        /// <li>You can try out the Voice Content Moderation Service free of charge in <a href="https://console.cloud.tencent.com/gamegme/tryout">GME Console > Voice Content Moderation > Product Trial</a>.</li>
        /// </br>
        /// 
        /// <h4><b>API feature description:</b></h4>
        /// <li>This API checks voice streams or files for non-compliant content.</li>
        /// <li>The detection result can be queried by setting the callback address (`Callback`) or calling the `DescribeScanResultList` API for polling.</li>
        /// <li>The scenario can be specified, such as abusive or pornographic.</li>
        /// <li>Detection tasks can be submitted in batches. Up to 100 tasks can be added in the detection task list.</li>
        /// </br>
        /// <h4><b>Audio file limits:</b></h4>
        /// <li>Audio file size limit: 100 MB</li>
        /// <li>Audio file duration limit: 30 minutes</li>
        /// <li>Supported audio file formats: .wav, .m4a, .amr, .mp3, .aac, .wma, .ogg</li>
        /// </br>
        /// <h4><b>Voice stream limits:</b></h4>
        /// <li>Supported voice stream formats: .m3u8, .flv</li>
        /// <li>Supported voice stream transfer protocols: RTMP, HTTP, HTTPS</li>
        /// <li>Voice stream duration limit: 4 hours</li>
        /// <li>Audio/video stream separation and audio stream analysis are supported</li>
        /// </br>
        /// <h4 id="Label_Value"><b>`Scenes` and `Label` parameter description:</b></h4>
        /// <p>When submitting a voice detection task, you need to specify the `Scenes` parameter. <font color="red">You are currently required to set the `Scenes` parameter to `["default"]`</font>. The detection result will contain the scenario specified at the time of request and detection result in the corresponding type.</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Voice detection</td>
        /// <td>Voice detection type</td>
        /// <td>
        /// <p>normal: Normal</p>
        /// <p>porn: Pornographic</p>
        /// <p>abuse: Abusive</p>
        /// <p>ad: Advertising</p>
        /// <p>illegal: Illegal</p>
        /// <p>moan: Moaning </p>
        /// <p>customized: Custom dictionary</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>Callback description:</b></h4>
        /// <li>If the callback address parameter `Callback` (i.e., the URL of an HTTP(S) API) is specified in the request parameters, then the POST method should be supported and transferred data should be encoded with UTF-8.</li>
        /// <li>After the callback data is pushed, if the HTTP status code received is 200, the push is successful.</li>
        /// <li>HTTP header parameter description:</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>Item</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Signature. For more information, please see <a href="#Callback_Signatue">Signature generation description</a>.</td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>Signature generation description:</li>
        /// 	<ul>
        /// 		<li>The HMAC-SH1 algorithm should be used, and the result should be encoded with Base64;</li>
        /// 		<li>The original signature string is the entire JSON content of POST and body (the length is subject to `Content-Length`);</li>
        /// 		<li>The signature key is the `SecretKey` of the application, which can be viewed in the console.</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>Sample callback <font color="red">(for more information on the fields, please see the structure:
        /// <a href="https://intl.cloud.tencent.com/document/api/607/35375?from_cn_redirect=1#DescribeScanResult" target="_blank">DescribeScanResult</a>)</font>:</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req"><see cref="ScanVoiceRequest"/></param>
        /// <returns><see cref="ScanVoiceResponse"/></returns>
        public async Task<ScanVoiceResponse> ScanVoice(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to submit a voice detection task. Up to 100 tasks can be added in the detection task list. Before using this API, please activate the Voice Content Moderation Service in [GME Console > Voice Content Moderation > Service Configuration](https://console.cloud.tencent.com/gamegme/conf).
        /// </br></br>
        /// 
        /// <h4><b>About the trial:</b></h4>
        /// <li>You can try out the Voice Content Moderation Service free of charge in <a href="https://console.cloud.tencent.com/gamegme/tryout">GME Console > Voice Content Moderation > Product Trial</a>.</li>
        /// </br>
        /// 
        /// <h4><b>API feature description:</b></h4>
        /// <li>This API checks voice streams or files for non-compliant content.</li>
        /// <li>The detection result can be queried by setting the callback address (`Callback`) or calling the `DescribeScanResultList` API for polling.</li>
        /// <li>The scenario can be specified, such as abusive or pornographic.</li>
        /// <li>Detection tasks can be submitted in batches. Up to 100 tasks can be added in the detection task list.</li>
        /// </br>
        /// <h4><b>Audio file limits:</b></h4>
        /// <li>Audio file size limit: 100 MB</li>
        /// <li>Audio file duration limit: 30 minutes</li>
        /// <li>Supported audio file formats: .wav, .m4a, .amr, .mp3, .aac, .wma, .ogg</li>
        /// </br>
        /// <h4><b>Voice stream limits:</b></h4>
        /// <li>Supported voice stream formats: .m3u8, .flv</li>
        /// <li>Supported voice stream transfer protocols: RTMP, HTTP, HTTPS</li>
        /// <li>Voice stream duration limit: 4 hours</li>
        /// <li>Audio/video stream separation and audio stream analysis are supported</li>
        /// </br>
        /// <h4 id="Label_Value"><b>`Scenes` and `Label` parameter description:</b></h4>
        /// <p>When submitting a voice detection task, you need to specify the `Scenes` parameter. <font color="red">You are currently required to set the `Scenes` parameter to `["default"]`</font>. The detection result will contain the scenario specified at the time of request and detection result in the corresponding type.</p>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>Scenario</th>
        /// <th>Description</th>
        /// <th>Label</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Voice detection</td>
        /// <td>Voice detection type</td>
        /// <td>
        /// <p>normal: Normal</p>
        /// <p>porn: Pornographic</p>
        /// <p>abuse: Abusive</p>
        /// <p>ad: Advertising</p>
        /// <p>illegal: Illegal</p>
        /// <p>moan: Moaning </p>
        /// <p>customized: Custom dictionary</p>
        /// </td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// </br>
        /// <h4 id="Callback_Declare"><b>Callback description:</b></h4>
        /// <li>If the callback address parameter `Callback` (i.e., the URL of an HTTP(S) API) is specified in the request parameters, then the POST method should be supported and transferred data should be encoded with UTF-8.</li>
        /// <li>After the callback data is pushed, if the HTTP status code received is 200, the push is successful.</li>
        /// <li>HTTP header parameter description:</li>
        /// <table>
        /// <thread>
        /// <tr>
        /// <th>Item</th>
        /// <th>Type</th>
        /// <th>Required</th>
        /// <th>Description</th>
        /// </tr>
        /// </thread>
        /// <tbody>
        /// <tr>
        /// <td>Signatue</td>
        /// <td>string</td>
        /// <td>Yes</td>
        /// <td>Signature. For more information, please see <a href="#Callback_Signatue">Signature generation description</a>.</td>
        /// </tr>
        /// </tbody>
        /// </table>
        /// <ul  id="Callback_Signatue">
        /// 	<li>Signature generation description:</li>
        /// 	<ul>
        /// 		<li>The HMAC-SH1 algorithm should be used, and the result should be encoded with Base64;</li>
        /// 		<li>The original signature string is the entire JSON content of POST and body (the length is subject to `Content-Length`);</li>
        /// 		<li>The signature key is the `SecretKey` of the application, which can be viewed in the console.</li>
        /// 	</ul>
        /// </ul>
        /// 
        /// <li>Sample callback <font color="red">(for more information on the fields, please see the structure:
        /// <a href="https://intl.cloud.tencent.com/document/api/607/35375?from_cn_redirect=1#DescribeScanResult" target="_blank">DescribeScanResult</a>)</font>:</li>
        /// <pre><code>{
        /// 	"Code": 0,
        /// 	"DataId": "1400000000_test_data_id",
        /// 	"ScanFinishTime": 1566720906,
        /// 	"HitFlag": true,
        /// 	"Live": false,
        /// 	"Msg": "",
        /// 	"ScanPiece": [{
        /// 		"DumpUrl": "",
        /// 		"HitFlag": true,
        /// 		"MainType": "abuse",
        /// 		"RoomId": "123",
        /// 		"OpenId": "xxx",
        /// 		"Info":"",
        /// 		"Offset": 0,
        /// 		"Duration": 3400,
        /// 		"PieceStartTime":1574684231,
        /// 		"ScanDetail": [{
        /// 			"EndTime": 1110,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 1110
        /// 		}, {
        /// 			"EndTime": 1380,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 1560,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 930
        /// 		}, {
        /// 			"EndTime": 2820,
        /// 			"KeyWord": "xxx",
        /// 			"Label": "abuse",
        /// 			"Rate": "90.00",
        /// 			"StartTime": 2490
        /// 		}]
        /// 	}],
        /// 	"ScanStartTime": 1566720905,
        /// 	"Scenes": [
        /// 		"default"
        /// 	],
        /// 	"Status": "Success",
        /// 	"TaskId": "xxx",
        /// 	"Url": "https://xxx/xxx.m4a"
        /// }
        /// </code></pre>
        /// </summary>
        /// <param name="req"><see cref="ScanVoiceRequest"/></param>
        /// <returns><see cref="ScanVoiceResponse"/></returns>
        public ScanVoiceResponse ScanVoiceSync(ScanVoiceRequest req)
        {
             JsonResponseModel<ScanVoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanVoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanVoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
