using Identitim.Auth.Common.ModelBinder;

namespace Identitim.Auth.Common.Attributes;

using Microsoft.AspNetCore.Mvc;

public class FromAuthorizationHeaderAttribute() : ModelBinderAttribute(typeof(TokenModelBinder));