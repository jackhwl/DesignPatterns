/// <summary>
/// Root object for any script function used throughout the application
/// </summary>
var Todo01 = Todo01 || {};
Todo01.RootServer = "";        // Should be set to /vdir when deployed

/// <summary>
/// Return a root-based path
/// </summary>
Todo01.fromServer = function (relativeUrl) {
    return Todo01.RootServer + relativeUrl;
};


Todo01.post = function (url, data, success, error) {
    $.ajax({
        cache: false,
        url: Todo01.fromServer(url),
        type: 'post',
        data: data,
        success: success,
        error: error
    });
};